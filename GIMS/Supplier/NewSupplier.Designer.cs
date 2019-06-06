namespace GIMS.Supplier
{
    partial class NewSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSupplierName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSupplierAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkIsActive = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtRemarks = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContactNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Location = new System.Drawing.Point(113, 70);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(282, 20);
            this.txtSupplierId.TabIndex = 1;
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.Location = new System.Drawing.Point(582, 515);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSupplier.TabIndex = 7;
            this.btnSaveSupplier.Text = "Save";
            this.btnSaveSupplier.UseVisualStyleBackColor = true;
            this.btnSaveSupplier.Click += new System.EventHandler(this.btnSaveSupplier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(auto-generated)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Supplier";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(677, 2);
            this.label6.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(663, 515);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Depth = 0;
            this.txtSupplierName.Hint = "";
            this.txtSupplierName.Location = new System.Drawing.Point(117, 127);
            this.txtSupplierName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.Size = new System.Drawing.Size(320, 23);
            this.txtSupplierName.TabIndex = 2;
            this.txtSupplierName.UseSystemPasswordChar = false;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Depth = 0;
            this.txtSupplierAddress.Hint = "";
            this.txtSupplierAddress.Location = new System.Drawing.Point(118, 162);
            this.txtSupplierAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.PasswordChar = '\0';
            this.txtSupplierAddress.SelectedText = "";
            this.txtSupplierAddress.SelectionLength = 0;
            this.txtSupplierAddress.SelectionStart = 0;
            this.txtSupplierAddress.Size = new System.Drawing.Size(574, 23);
            this.txtSupplierAddress.TabIndex = 3;
            this.txtSupplierAddress.UseSystemPasswordChar = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Depth = 0;
            this.chkIsActive.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkIsActive.Location = new System.Drawing.Point(110, 279);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(0);
            this.chkIsActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIsActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Ripple = true;
            this.chkIsActive.Size = new System.Drawing.Size(79, 30);
            this.chkIsActive.TabIndex = 6;
            this.chkIsActive.Text = "Enabled";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Depth = 0;
            this.txtRemarks.Hint = "";
            this.txtRemarks.Location = new System.Drawing.Point(118, 239);
            this.txtRemarks.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.Size = new System.Drawing.Size(574, 23);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 240);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Remarks";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(45, 163);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Address";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(56, 126);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(24, 201);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 18);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Contact No.";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Depth = 0;
            this.txtContactNumber.Hint = "";
            this.txtContactNumber.Location = new System.Drawing.Point(117, 202);
            this.txtContactNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.SelectionLength = 0;
            this.txtContactNumber.SelectionStart = 0;
            this.txtContactNumber.Size = new System.Drawing.Size(320, 23);
            this.txtContactNumber.TabIndex = 4;
            this.txtContactNumber.UseSystemPasswordChar = false;
            // 
            // NewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveSupplier);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewSupplier";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierAddress;
        private MaterialSkin.Controls.MaterialCheckBox chkIsActive;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRemarks;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactNumber;
    }
}