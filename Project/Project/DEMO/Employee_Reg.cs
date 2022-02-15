using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace DEMO
{
    

    public partial class Employee_Reg : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\DEMO\Demo.mdf;Integrated Security = True; Connect Timeout = 30");

        //database
        public Employee_Reg()
        {
            InitializeComponent();
        }
        string Gender;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Reg_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female"; 
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [EmpReg] (Employee_Name,ID,PresentAddress,PermanentAddress,ContactNo,Nationalty,NIDNO,Religion,Age,Designation,Salary,HireDate) values ('" + EmployeeName.Text + "','" + ID.Text + "','" + PresentAddress.Text + "','" + Permanent_Address.Text + "','" + Contact_Number.Text + "','" + Nationalty.Text + "','" + NIDNO.Text + "','" + Religion.Text + "','" + Age.Text + "','" + Designation.Text + "','" + Salary.Text + "','" + HireDate.Text + " ' ) ";
            cmd.ExecuteNonQuery(); 
            connection.Close();
            EmployeeName.Text = "";
            ID.Text = "";
            //Gender.Text = "";
            PresentAddress.Text = "";
            Permanent_Address.Text = "";
            Contact_Number.Text = "";
            Nationalty.Text += "";
            NIDNO.Text = "";
            Religion.Text ="";
            Age.Text ="";
            Designation.Text ="";
            Salary.Text = "";
            HireDate.Text = "";
             
            MessageBox.Show("EmployeeRegistered");


    }

        //to display data
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [EmpReg]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable() ;
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            datagridview.DataSource = dta;
            connection.Close();
            



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
