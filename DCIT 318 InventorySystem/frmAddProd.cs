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
    public partial class frmAddProd : Form
    {
        public frmAddProd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invCRUD.sql("INSERT INTO `stockitems`(`Itemcode`, `Itemname`, `ItemSize`, `ItemColour`, `ItemCategory`, `ItemPrice`, `ItemQty`, `Reoderlevel`) " +
                "VALUES ('"+ txtItemcode.Text + "','" + txtItemname.Text + "','" + txtSize.Text + "','" + txtColor.Text + "','" + cbCat.Text + "','" + txtPrice.Text + "','" + txtQty.Text + "','" + txtReoder.Text + "')");
            
        }

        private void frmAddProd_Load(object sender, EventArgs e)
        {
           
        }
    }
}
