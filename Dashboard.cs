using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
                btnManageEmployee.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
                btnManageEmployee.Show();
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void uC_Welcome1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_ManageEmployee1.Visible = false;
        }

        private void uC_AddItems1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void uC_PlaceOrder3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uC_ManageEmployee1.Visible = true;
            uC_ManageEmployee1.BringToFront();
        }
    }
}
