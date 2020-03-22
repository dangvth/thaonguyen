using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PetStore
{
    public partial class rbbSell : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable table;
        public rbbSell()
        {
            InitializeComponent();
            resetTable();
        }

        private void resetTable()
        {
            table = new DataTable();
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("Price", typeof(int)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            dataGridView1.DataSource = table;
        }

        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbbSelectProduct slp = new rbbSelectProduct();
            slp.ShowDialog(this);
            if (slp.status != -1)
            {
                DataGridViewRow row = slp.grvProduct.Rows[slp.status];
                table.Rows.Add(row.Cells["Name"].Value.ToString(), row.Cells["Price"].Value.ToString(), slp.qty);    
            }
        }
    }
}