using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCIT_318_InventorySystem
{
    public partial class frmManageprod : Form
    {
        
        public frmManageprod()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            invCRUD.display("select * from stockitems", dataGridView1);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            invCRUD.display("select * from category", dataGridView2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           frmAddProd prod = new frmAddProd();
            prod.ShowDialog();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            EditProduct prod = new EditProduct();
            prod.ukey = row.Cells["itemcode"].Value.ToString();
            prod.ShowDialog();
        }
        
    }
}
