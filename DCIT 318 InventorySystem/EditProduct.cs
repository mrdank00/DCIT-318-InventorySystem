using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DCIT_318_InventorySystem
{
    public partial class EditProduct : Form
        
    {
        public string ukey { get; set; }
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = invCRUD.invcon();
            string query = "select * from stockitems where itemcode='"+ ukey +"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtItemcode.Text = dr.GetValue(0).ToString();
                txtItemname.Text = dr.GetValue(1).ToString();
                txtSize.Text = dr.GetValue(2).ToString();
                txtColor.Text = dr.GetValue(3).ToString();
                cbCat.Text = dr.GetValue(4).ToString();
                txtPrice.Text = dr.GetValue(5).ToString();
                txtQty.Text = dr.GetValue(6).ToString();
                txtReoder.Text = dr.GetValue(7).ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            invCRUD.sql("UPDATE `stockitems` SET `Itemname`='" + txtItemname.Text + "'," +
                "`ItemSize`='" + txtSize.Text + "',`ItemColour`='" + txtColor.Text + "',`ItemCategory`='" + cbCat.Text + "'," +
                "`ItemPrice`='" + txtPrice.Text + "',`ItemQty`='" + txtQty.Text + "',`Reoderlevel`='" + txtReoder.Text + "' " +
                "WHERE Itemcode='" + ukey + "'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invCRUD.sql("DELETE FROM `stockitems` WHERE itemcode='" + ukey + "'");

        }
    }
}
