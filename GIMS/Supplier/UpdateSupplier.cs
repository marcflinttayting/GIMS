using GIMS.Domain;
using GIMS.Domain.dto;
using Newtonsoft.Json;
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
    public partial class frmUpdateSupplier : Form
    {
        private readonly SupplierManager _manager;
        public frmUpdateSupplier(SupplierManager manager)
        {
            InitializeComponent();

            _manager = manager;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var result = _manager.GetAll();

            gvSuppliers.AutoGenerateColumns = false;
            gvSuppliers.DataSource = result;
        }

        private void gvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = gvSuppliers.Rows[e.RowIndex];

            if (selectedRow == null)
            {
                MessageBox.Show("System Error!", "GIMS Error");
            }
        }

        private void gvSuppliers_clicked(object sender, DataGridViewCellEventArgs e)
        {
            var row = ((DataGridView)sender).SelectedRows[0]?.DataBoundItem;

            if (row == null)
                return;

            var obj = JsonConvert.DeserializeObject<SupplierResponseDto>(JsonConvert.SerializeObject(row));

            FillDetails(obj);
        }

        public void gvSuppliers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                var selectedrow = gvSuppliers.SelectedRows[0];

                var row = ((DataGridView)sender).SelectedRows[0]?.DataBoundItem;

                if (row == null)
                    return;

                var obj = JsonConvert.DeserializeObject<SupplierResponseDto>(JsonConvert.SerializeObject(row));

                FillDetails(obj);
            }
        }

        private void FillDetails(SupplierResponseDto obj)
        {
            if (obj == null)
                return;

            if (obj != null)
            {
                txtSupplierName.Text = obj.Name;
                txtSupplierAddress.Text = obj.Address;
                txtSupplierId.Text = obj.SupplierId.ToString();
                txtRemarks.Text = obj.Remarks;
            }
        }


        private void UpdateSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
