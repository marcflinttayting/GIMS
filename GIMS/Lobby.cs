using GIMS.Domain;
using GIMS.Supplier;
using GIMS.Transactions;
using MaterialSkin;
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
using log4net;

namespace GIMS
{
    public partial class Lobby : MaterialForm
    {
        private readonly SupplierManager _supplierManager;
        private readonly ILog _logger;
        public Lobby(SupplierManager supplierManager, ILog logger)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            _supplierManager = supplierManager;
            _logger = logger;

            _logger.Info("Lobby entered...");
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeMainPanel(new NewSupplier(_supplierManager), pnlMain);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            InitializeMainPanel(new Dashboard(), pnlMain);
        }

        private void InitializeMainPanel(Form form, Panel targetPanel)
        {
            if (form == null)
                return;

            if (targetPanel == null)
                return;

            targetPanel.Controls.Clear();

            form.TopLevel = false;
            form.TopMost = false;
            form.ShowInTaskbar = false;

            targetPanel.Controls.Add(form);
            form.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            InitializeMainPanel(new Deliveries(), pnlMain);
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            InitializeMainPanel(new frmUpdateSupplier(_supplierManager), pnlMain);
        }
    }
}
