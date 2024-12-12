using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poslednie_sklad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnWarehouses_Click(object sender, EventArgs e)
        {
            WarehousesForm warehousesForm = new WarehousesForm();
            warehousesForm.ShowDialog();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void BtnGoods_Click(object sender, EventArgs e)
        {
            GoodsForm goodsForm = new GoodsForm();
            goodsForm.ShowDialog();
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            ContractsForm contractsForm = new ContractsForm();
            contractsForm.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        
    }
    // Пустые формы для демонстрации переходов
    public class WarehousesForm : Form
    {
        public WarehousesForm()
        {
            this.Text = "Управление складами";
            this.Size = new System.Drawing.Size(400, 300);
        }
    }

    public class ClientsForm : Form
    {
        public ClientsForm()
        {
            this.Text = "Управление клиентами";
            this.Size = new System.Drawing.Size(400, 300);
        }
    }

    public class GoodsForm : Form
    {
        public GoodsForm()
        {
            this.Text = "Управление ТМЦ";
            this.Size = new System.Drawing.Size(400, 300);
        }
    }

    public class ContractsForm : Form
    {
        public ContractsForm()
        {
            this.Text = "Управление договорами";
            this.Size = new System.Drawing.Size(400, 300);
        }
    }

    public class ReportsForm : Form
    {
        public ReportsForm()
        {
            this.Text = "Отчеты";
            this.Size = new System.Drawing.Size(400, 300);
        }
    }
}
