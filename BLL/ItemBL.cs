using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using QBuildDesktop.DAL;
using QBuildDesktop.BO;
using System.Windows.Forms;

namespace QBuildDesktop.BLL
{
    class ItemBL
    {

        #region Properties
        static log4net.ILog log; 
        #endregion

        #region Constructors
        public ItemBL()
        {
            log = log4net.LogManager.GetLogger(typeof(ItemBL));
        }
        #endregion

        #region Get Methods
        /// <summary>
        /// Get all items from the context
        /// </summary>
        /// <returns>A list of Items</returns>
        public List<Item> GetAllItems()
        {
            try
            {
                log.Info("Get all items method called");
                log.Debug("getAllItems() Called");

                var bomContext = new BomContext();
                return bomContext.Items.Find("{}").ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets top level items where the parent id is equals to ""
        /// </summary>
        /// <returns>List of Items</returns>
        public List<Item> GetTopLevelItems()
        {
            try
            {
                log.Info("Get top level items method called");
                log.Debug("GetTopLevelItems() Called");
                var bomContext = new BomContext();
                return bomContext.Items.Find("{\"PARENT_NAME\": \"\"}").ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Items as a TreeNode
        /// </summary>
        /// <returns>List of TreeNodes</returns>
        public List<TreeNode> GetAllItemsAsATreeNode()
        {
            log.Info("Get all items as a tree node method called");
            log.Debug("GetAllItemsAsATreeNode() Called");

            List<TreeNode> topLevelTreeNodes = new List<TreeNode>();

            try
            {

                ItemBL itemBL = new ItemBL();

                log.Info("Getting top level items");

                List<Item> topLevelItems = itemBL.GetTopLevelItems();

                log.Info("Getting top level items finished. No of top level items :" + topLevelItems.Count);
                log.Info("Getting chiled nodes for top level items");

                foreach (var item in topLevelItems)
                {
                    TreeNode treeNodeTop = new TreeNode(item.ComponentName);

                    GetChlildCollection(this.GetAllItems(), item.ComponentName, ref treeNodeTop);

                    topLevelTreeNodes.Add(treeNodeTop);

                }

                log.Info("Getting chiled nodes for top level items finished");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
                throw;
            }

            return topLevelTreeNodes;
        }

        /// <summary>
        /// Get all the child nodes with their childs
        /// </summary>
        /// <param name="Items">Item list from the context</param>
        /// <param name="ComponentName">Parent component name</param>
        /// <param name="treeNodeList">TreeNode as a referrence</param>
        public void GetChlildCollection(List<Item> Items, string ComponentName, ref TreeNode treeNodeList)
        {
            //logs were not included because of this method is heavily use in generating the tree view
            try
            {
                if (Items != null && !String.IsNullOrWhiteSpace(ComponentName))
                {
                    List<Item> childList = Items.FindAll(x => x.ParentName == ComponentName);

                    if (childList.Count > 0)
                    {
                        foreach (var item in childList)
                        {
                            TreeNode childNode = new TreeNode(item.ComponentName);
                            treeNodeList.Nodes.Add(childNode);
                            GetChlildCollection(Items, item.ComponentName, ref childNode);
                        }
                    }
                }
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
