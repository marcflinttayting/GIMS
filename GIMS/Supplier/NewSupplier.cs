using GIMS.Domain;
using GIMS.Domain.dto;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMS.Supplier
{
    public partial class NewSupplier : Form
    {
        private readonly SupplierManager _supplierManager;

        public NewSupplier(SupplierManager supplierManager)
        {
            InitializeComponent();

            _supplierManager = supplierManager;
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            txtSupplierId.Text = Guid.NewGuid().ToString().ToUpper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            var entity = new SupplierRequestDto()
            {
                Address = txtSupplierAddress.Text.Trim(),
                ContactNumber = txtContactNumber.Text.Trim(),
                Remarks = txtRemarks.Text.Trim(),
                IsActive = chkIsActive.Checked,
                Name = txtSupplierName.Text.Trim(),
                SupplierId = new Guid(txtSupplierId.Text)
            };

            try
            {
                var res = _supplierManager.Add(entity);

                if(res > 0)
                {
                    MessageBox.Show("Save successful!", "Success");
                    Reset();
                    return;
                }

                MessageBox.Show("Saving not successful.Please retry.", "Error");
            }
           catch(Exception ex)
            {
                MessageBox.Show("Error saving supplier information.", "Error");
                //logger
            }
        }


        private void Reset()
        {
            foreach(var c in this.Controls)
            {
                var textbox = c as MaterialSingleLineTextField;
                var chk = c as MaterialCheckBox;

                if (textbox != null)
                    textbox.Text = string.Empty;

                if (chk != null)
                    chk.Checked = true;
            }
        }

    }
}
