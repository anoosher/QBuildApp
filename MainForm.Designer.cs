namespace QBuildDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCaption = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPopulateTree = new System.Windows.Forms.Button();
            this.lblCurrPartValue = new System.Windows.Forms.Label();
            this.lblCurrPart = new System.Windows.Forms.Label();
            this.lblDescValue = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.treeViewBOM = new System.Windows.Forms.TreeView();
            this.gridViewPartDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(258, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(313, 20);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Testing Functionality for Tree and Datagrid ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPopulateTree);
            this.panel1.Controls.Add(this.lblCurrPartValue);
            this.panel1.Controls.Add(this.lblCurrPart);
            this.panel1.Controls.Add(this.lblDescValue);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.treeViewBOM);
            this.panel1.Location = new System.Drawing.Point(13, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 231);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(319, 114);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit from Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPopulateTree
            // 
            this.btnPopulateTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulateTree.Location = new System.Drawing.Point(319, 79);
            this.btnPopulateTree.Name = "btnPopulateTree";
            this.btnPopulateTree.Size = new System.Drawing.Size(210, 29);
            this.btnPopulateTree.TabIndex = 5;
            this.btnPopulateTree.Text = "Populate Data in Tree";
            this.btnPopulateTree.UseVisualStyleBackColor = true;
            this.btnPopulateTree.Click += new System.EventHandler(this.btnPopulateTree_Click);
            // 
            // lblCurrPartValue
            // 
            this.lblCurrPartValue.AutoSize = true;
            this.lblCurrPartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrPartValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCurrPartValue.Location = new System.Drawing.Point(433, 44);
            this.lblCurrPartValue.Name = "lblCurrPartValue";
            this.lblCurrPartValue.Size = new System.Drawing.Size(96, 15);
            this.lblCurrPartValue.TabIndex = 4;
            this.lblCurrPartValue.Text = "lblCurrPartValue";
            // 
            // lblCurrPart
            // 
            this.lblCurrPart.AutoSize = true;
            this.lblCurrPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrPart.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCurrPart.Location = new System.Drawing.Point(316, 44);
            this.lblCurrPart.Name = "lblCurrPart";
            this.lblCurrPart.Size = new System.Drawing.Size(78, 15);
            this.lblCurrPart.TabIndex = 3;
            this.lblCurrPart.Text = "Current Part :";
            // 
            // lblDescValue
            // 
            this.lblDescValue.AutoSize = true;
            this.lblDescValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescValue.ForeColor = System.Drawing.Color.Red;
            this.lblDescValue.Location = new System.Drawing.Point(433, 17);
            this.lblDescValue.Name = "lblDescValue";
            this.lblDescValue.Size = new System.Drawing.Size(79, 15);
            this.lblDescValue.TabIndex = 2;
            this.lblDescValue.Text = "lblDescValue";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Red;
            this.lblDesc.Location = new System.Drawing.Point(316, 17);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(111, 15);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Parent / Child Part :";
            // 
            // treeViewBOM
            // 
            this.treeViewBOM.Location = new System.Drawing.Point(4, 4);
            this.treeViewBOM.Name = "treeViewBOM";
            this.treeViewBOM.Size = new System.Drawing.Size(305, 222);
            this.treeViewBOM.TabIndex = 0;
            this.treeViewBOM.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewBOM_AfterSelect);
            // 
            // gridViewPartDetails
            // 
            this.gridViewPartDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewPartDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPartDetails.Location = new System.Drawing.Point(13, 286);
            this.gridViewPartDetails.Name = "gridViewPartDetails";
            this.gridViewPartDetails.Size = new System.Drawing.Size(812, 252);
            this.gridViewPartDetails.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 554);
            this.Controls.Add(this.gridViewPartDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "QBuild";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewBOM;
        private System.Windows.Forms.Label lblDescValue;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPopulateTree;
        private System.Windows.Forms.Label lblCurrPartValue;
        private System.Windows.Forms.Label lblCurrPart;
        private System.Windows.Forms.DataGridView gridViewPartDetails;
    }
}

