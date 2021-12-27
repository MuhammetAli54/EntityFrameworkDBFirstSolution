using EntityFrameworkDBFirst_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDBFirst_WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global alan
        ProductManager myProductManager = new ProductManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklenirken grid'e product bilgileri gelsin.
            GrideProductlariGetir();
        }

        private void GrideProductlariGetir()
        {
            //BLL aracılığıyla listemiz gelecek
            dataGridView1.DataSource = myProductManager.TumUrunleriGetir();
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;

        }
    }
}
