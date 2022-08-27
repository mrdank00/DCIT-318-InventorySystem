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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            invCRUD.combofeed("select itemname from stockitems", comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = invCRUD.invcon();
            MySqlCommand cmd = new MySqlCommand("select * from stockitems where itemname='"+comboBox1.Text+"'", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtPrice.Text = dr.GetValue(5).ToString();
                lblitemname.Text = dr.GetValue(1).ToString();
            }
            else
            {
                MessageBox.Show("No such Item");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var row in dataGridView1.Rows)
            {
              //  invCRUD.sql("INSERT INTO `salestransaction`(`SalesID`, `Itemcode`, `Itemname`, `Price`, `Qty`, `Amount`) " +
              //"VALUES ('" + + "','[value-2]','[value-3]','[value-4]','[value-5]','[value-6]')");
            }
          
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            decimal amt = Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQty.Text);
            txtAmt.Text = amt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(lblitemname.Text,txtPrice.Text,txtQty.Text,txtAmt.Text);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double Total=0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                    Total += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    label6.Text = Total.ToString();
            }
        }

        private void textBox3_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text.Length > 0)
            {
                double change = 0;
                change = Convert.ToDouble(label6.Text) - Convert.ToDouble(textBox3.Text);
                label7.Text = change.ToString();
            }
         
        }
    }
}
