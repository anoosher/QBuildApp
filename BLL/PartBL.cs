using QBuildDesktop.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QBuildDesktop.DAL;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QBuildDesktop.BLL
{
    class PartBL
    {
        #region Properties
        static log4net.ILog log;
        #endregion


        #region Constructors
        public PartBL()
        {
            log = log4net.LogManager.GetLogger(typeof(PartBL));
        }
        #endregion

        #region Get Methods

        /// <summary>
        /// Gets the part by its part name
        /// </summary>
        /// <param name="PartName"></param>
        /// <returns></returns>
        public Part GetPartByComponentName(string PartName)
        {
            try
            {
                log.Info("Get part by component name method called");
                log.Debug("GetPartByComponentName() Called");

                var bomContext = new BomContext();
                return bomContext.Parts.Find(x => x.Name == PartName).SingleOrDefault();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Get all parts by its parent name
        /// </summary>
        /// <param name="ParentName">Parent item's name</param>
        /// <returns></returns>
        public List<Part> GetPartsByParent(string ParentName)
        {
            try
            {

                log.Info("Get part by component name method called");
                log.Debug("GetPartByComponentName() Called");


                log.Debug("Getting child item list by parent name");
                log.Info("Getting child item list by parent name");
                var bomContext = new BomContext();
                List<Item> childItemList = bomContext.Items.Find(x => x.ParentName == ParentName).ToList();

                log.Debug("Getting child item list by parent name finished. No of items found:" + childItemList.Count);
                log.Info("Getting child item list by parent name finished");

                List<Part> partList = new List<Part>();


                log.Debug("Getting parts for those child items");
                log.Info("Getting parts for those child items");

                foreach (var item in childItemList)
                {
                    Part part = bomContext.Parts.Find(x => x.Name == item.ComponentName).FirstOrDefault();

                    if (part != null)
                    {
                        part.ComponentName = item.ComponentName;
                        part.Quantity = item.Quantity;
                        partList.Add(part);
                    }
                }

                log.Debug("Getting parts for those child items finished. No of parts found:" + partList.Count);
                log.Info("Getting parts for those child items finished");

                return partList;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
                throw;
            }
        } 
        #endregion
    }
}
