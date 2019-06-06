namespace GIMS
{
    partial class Lobby
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Supplier", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.btnProductCategories = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductCategories
            // 
            this.btnProductCategories.Location = new System.Drawing.Point(12, 228);
            this.btnProductCategories.Name = "btnProductCategories";
            this.btnProductCategories.Size = new System.Drawing.Size(131, 23);
            this.btnProductCategories.TabIndex = 4;
            this.btnProductCategories.Text = "Product Categories";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(12, 199);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(131, 23);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Products";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Location = new System.Drawing.Point(12, 170);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(131, 23);
            this.btnDeliveries.TabIndex = 2;
            this.btnDeliveries.Text = "Deliveries";
            this.btnDeliveries.Click += new System.EventHandler(this.btnDeliveries_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(18, 341);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(131, 23);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(12, 70);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(137, 31);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "New Supplier";
            this.btnSupplier.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(171, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(825, 606);
            this.pnlMain.TabIndex = 7;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 419);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "New";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Update";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Supplier";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 8;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(12, 107);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(137, 31);
            this.btnUpdateSupplier.TabIndex = 9;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnProductCategories);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnDeliveries);
            this.Controls.Add(this.btnDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lobby";
            this.Text = "GIMS";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProductCategories;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnDeliveries;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnUpdateSupplier;
    }
}

