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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invCRUD.sql("INSERT INTO `users`( `UserID`, `Username`, `Password`, `Usertype`) " +
                "VALUES ('" + txtusername.Text + "','" + txtuserid.Text + "','" + txtpassword.Text + "','" + txtusertype.Text + "')");
            frmManageusers prod = new frmManageusers();
            prod.tabPage1_Enter(button1,e);

        }
    }
}
