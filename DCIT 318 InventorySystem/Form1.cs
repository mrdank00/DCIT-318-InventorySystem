﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = invCRUD.invcon();
            MySqlCommand cmd = new MySqlCommand("select * from users where userid='"+ textBox1.Text +"' and password='"+ textBox2.Text +"'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            if (tbl.Rows.Count<1)
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();


            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
            con.Close();
            //System.Windows.Forms.MessageBox.Show("Sucess0");

        }
    }
}
