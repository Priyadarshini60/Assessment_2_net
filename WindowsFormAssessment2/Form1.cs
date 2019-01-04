using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAssessment2
{
    public partial class Form1 : Form
    {
        Employee employee;
        int ID = 0;

        SqlDataAdapter adapt;
        SqlConnection con = new SqlConnection(@"Data Source=192.168.1.44\MSSQLSERVER_2017;Initial Catalog=CDAC;Persist Security Info=True;User ID=cdacdev;Password=cdacdev123#");

        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDACDataSet.New_Employee' table. You can move, or remove it, as needed.
            this.new_EmployeeTableAdapter1.Fill(this.cDACDataSet.New_Employee);
            // TODO: This line of code loads data into the 'cDACDataSet1.New_Employee' table. You can move, or remove it, as needed.
            this.new_EmployeeTableAdapter.Fill(this.cDACDataSet1.New_Employee);
            Display();
        }
        public void Display()
        {

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from New_Employee", con);  //query to display all records in data grid
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtInsert_Click(object sender, EventArgs e)
        {
            employee = new Employee(txtName.Text.ToString(), txtDesign.Text.ToString(),Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtSal.Text)); //employee class constructor call
            con.Open();    //to open connection with database
            string insert = "insert into New_Employee(EmpName,EmpDesignation,Age,Salary) values(@empname,@empdesgn,@ag,@sal)";
            cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@empname", employee.name);
            cmd.Parameters.AddWithValue("@empdesgn", employee.design);
            cmd.Parameters.AddWithValue("@ag", employee.age);
            cmd.Parameters.AddWithValue("@sal", employee.salary);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted ");
            Display();
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDesign.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSal.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete New_Employee where EmpID=@id", con);   //delete query
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
            Display();
        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            employee = new Employee(txtName.Text.ToString(), txtDesign.Text.ToString(), Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtSal.Text));
            string update = "update New_Employee set EmpName=@empname,EmpDesignation=@empdesg,Age=@empage,Salary=@sal where EmpID=@empId";
            con.Open();    //open connection with database
            command = new SqlCommand(update, con);
            command.Parameters.AddWithValue("@empId", ID);
            command.Parameters.AddWithValue("@empname", employee.name);
            command.Parameters.AddWithValue("@empdesg", employee.design);
            command.Parameters.AddWithValue("@empage", employee.age);
            command.Parameters.AddWithValue("@sal",employee.salary);
            command.CommandType = CommandType.Text;
            int i = command.ExecuteNonQuery();
            Display();
            MessageBox.Show(i + " Row(s) updated ");
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //private void textsearch_TextChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    con.Open();
        //    adapt = new SqlDataAdapter("select * from New_Employee where EmpName like '" + txtSearch.Text + "%'", con);
        //    dt = new DataTable();
        //    adapt.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();
        //}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            adapt = new SqlDataAdapter("select * from New_Employee where EmpName like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
