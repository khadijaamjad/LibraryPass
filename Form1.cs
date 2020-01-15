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
using System.Data.Sql;

namespace VP_LibraryPass
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"");
        SqlCommand cmd;
        SqlDataReader sdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string qu = "Insert into LibraryPass (StudentName,TeacherName,SubjectName,Topic,AsgtType,DueDate,DateAssigned) values ('" + tbStu.Text + "','" + tbTeacher.Text + "','" + ddSubject.selectedValue.ToString() + "','" + tbTopic.Text + "','" + ddType.selectedValue.ToString() + "',GetDate(), GetDate())";
            cmd = new SqlCommand(qu, con);
            sdr = cmd.ExecuteReader();
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gbData.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gbData.Visible = false;
        }

        private void gbData_Enter(object sender, EventArgs e)
        {
            string str = "SELECT * FROM LibraryPass";
            cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStored.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbData.Visible = false;
        }
    }
}
