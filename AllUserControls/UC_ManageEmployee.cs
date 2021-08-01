using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class UC_ManageEmployee : UserControl
    {
        function fn = new function();
        String query;
        public UC_ManageEmployee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "insert into employees (name, username, password, email, contact) values ('" + txtEmpName.Text + "','" + txtEmpUserName.Text + "','" + txtEmpPassword.Text + "','" + txtEmpEmail.Text + "','" + txtEmpContact.Text + "')";
            fn.setData(query);
            loadData();
            clearAll();
        }



        private void UC_ManageEmployee_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from employees";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }



        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            query = "select * from employees where name like '" + txtSearchEmployee.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            String username = guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            String password = guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            String email = guna2DataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            String contact = guna2DataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtEmpName.Text = name;
            txtEmpUserName.Text = username;
            txtEmpPassword.Text = password;
            txtEmpEmail.Text = email;
            txtEmpContact.Text = contact;
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            query = "update employees set name = '" + txtEmpName.Text + "', username = '" + txtEmpUserName.Text + "', password = '" + txtEmpPassword.Text + "', email = '" + txtEmpEmail.Text + "', contact = '" + txtEmpContact.Text + "' where emp_id = " + id + "";
            fn.setData(query);
            loadData();

            clearAll();
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove Employee?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from employees where emp_id = " + id + "";
                fn.setData(query);
                loadData();
                clearAll();
            }
        }

        public void clearAll()
        {
            txtEmpName.Clear();
            txtEmpUserName.Clear();
            txtEmpPassword.Clear();
            txtEmpEmail.Clear();
            txtEmpContact.Clear();
        }

    }
}
