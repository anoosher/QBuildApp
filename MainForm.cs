using QBuildDesktop.BLL;
using QBuildDesktop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QBuildDesktop.BO;

namespace QBuildDesktop
{
    public partial class MainForm : Form
    {

        static log4net.ILog log;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                //initializing the logger
                log4net.Config.XmlConfigurator.Configure();
                log = log4net.LogManager.GetLogger(typeof(MainForm));

                //Set default values to lables 
                if (treeViewBOM.SelectedNode != null)
                    lblCurrPartValue.Text = treeViewBOM.SelectedNode.Text;
                else
                    lblCurrPartValue.Text = "Not Loaded";

                if (treeViewBOM.SelectedNode != null)
                    lblDescValue.Text = treeViewBOM.SelectedNode.FullPath;
                else
                    lblDescValue.Text = "Not Loaded";

                log.Info("QBuild application loaded");
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show("An internel error occured", "QBuild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(e.Message);
                log.Error(e.StackTrace);

                if (dialogResult == DialogResult.OK)
                {
                    log.Info("Closing the QBuild application");
                    Application.Exit();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TODO: Close connections
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "QBuild", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                log.Info("Closing the QBuild application");
                Application.Exit();
            }

        }

        private void btnPopulateTree_Click(object sender, EventArgs e)
        {

            try
            {
                log.Info("Getting all items as a tree node");
                log.Debug("Calling ItemBL method getAllItemsAsATreeNode()");

                List<TreeNode> topNodeList = new ItemBL().GetAllItemsAsATreeNode();

                log.Info("Getting all items as a tree node completed. No of Top Nodes Found :" + topNodeList.Count);
                log.Debug("Calling ItemBL method getAllItemsAsATreeNode() finished");

                log.Debug("Looping top nodes for adding them to tree view");
                log.Info("Looping top nodes for adding them to tree view");
                foreach (var item in topNodeList)
                {
                    treeViewBOM.Nodes.Add(item);
                }

                log.Debug("Looping top nodes for adding them to tree view finished");
                log.Info("Looping top nodes for adding them to tree view finished");

                lblCurrPartValue.Text = treeViewBOM.Nodes[0].Text;
                lblDescValue.Text = treeViewBOM.Nodes[0].FullPath;

                log.Debug("Label values are set");
                log.Info("Label values are set");
            }
            catch (Exception ex)
            {

                DialogResult dialogResult = MessageBox.Show("An internel error occured", "QBuild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex.Message);
                log.Error(ex.StackTrace);

                if (dialogResult == DialogResult.OK)
                {
                    log.Info("Closing the QBuild application");
                    Application.Exit();
                }
            }

        }

        private void treeViewBOM_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                lblCurrPartValue.Text = treeViewBOM.SelectedNode.Text;
                lblDescValue.Text = treeViewBOM.SelectedNode.FullPath;

                log.Debug("Label values are set after node selection");
                log.Info("Label values are set after node selection");

                log.Info("Getting all parts related to selected parent node");
                log.Debug("Calling PartBL method getPartsByParent()");

                gridViewPartDetails.DataSource = new PartBL().GetPartsByParent(treeViewBOM.SelectedNode.Text);

                log.Info("Getting all parts related to selected parent node finished");
                log.Debug("Calling PartBL method getPartsByParent() finished");

                log.Info("Setting up column properties of the data grid view");
                log.Debug("Setting up column properties of the data grid view");

                #region Columns Settings
                gridViewPartDetails.Columns["Id"].Visible = false;
                gridViewPartDetails.Columns["Name"].Visible = false;
                gridViewPartDetails.Columns["PartNo"].DisplayIndex = 1;
                gridViewPartDetails.Columns["PartNo"].HeaderText = "PART_NUMBER";
                gridViewPartDetails.Columns["ComponentName"].DisplayIndex = 0;
                gridViewPartDetails.Columns["ComponentName"].HeaderText = "COMPONENT_NAME";
                gridViewPartDetails.Columns["Title"].DisplayIndex = 2;
                gridViewPartDetails.Columns["Title"].HeaderText = "TITLE";
                gridViewPartDetails.Columns["Quantity"].DisplayIndex = 3;
                gridViewPartDetails.Columns["Quantity"].HeaderText = "QUANTITY";
                gridViewPartDetails.Columns["Type"].DisplayIndex = 4;
                gridViewPartDetails.Columns["Type"].HeaderText = "TYPE";
                gridViewPartDetails.Columns["Item"].DisplayIndex = 5;
                gridViewPartDetails.Columns["Item"].HeaderText = "ITEM";
                gridViewPartDetails.Columns["Material"].DisplayIndex = 6;
                gridViewPartDetails.Columns["Material"].HeaderText = "MATERIAL"; 
                #endregion

                log.Info("Setting up column properties of the data grid view finished");
                log.Debug("Setting up column properties of the data grid view finished");
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("An internel error occured", "QBuild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex.Message);
                log.Error(ex.StackTrace);

                if (dialogResult == DialogResult.OK)
                {
                    log.Info("Closing the QBuild application");
                    Application.Exit();
                }
            }

        }
    }
}
