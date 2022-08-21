﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DCIT_318_InventorySystem
{
    internal class invCRUD
    {
        public static MySqlConnection invcon()
        {
            string constr = "datasource=localhost;port=3306;username=root;password=;database=inventorysys";
            MySqlConnection con = new MySqlConnection(constr);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
                throw;
            }
            return con;
            
        }
        public static void sql(string sqlcon)
        {
            MySqlConnection conn=invcon();
            MySqlCommand cmd = new MySqlCommand(sqlcon,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            System.Windows.Forms.MessageBox.Show("Sucess");

        }
        public static void display(string sqlcon,DataGridView dgv)
        {
            MySqlConnection conn = invcon();
            MySqlCommand cmd = new MySqlCommand(sqlcon, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da=new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
            System.Windows.Forms.MessageBox.Show("Sucess0");

        }


    }
}
