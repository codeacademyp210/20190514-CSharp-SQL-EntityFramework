using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["AcademyDB"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();

            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("ID daxil edin");
                return;
            }

            int studentId;
            try
            {
                studentId = Convert.ToInt32(idText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID reqem deyil");
                return;
            }


            SqlConnection conn = new SqlConnection(connString);

            string commantString = "SELECT * FROM Students WHERE Id=" + studentId;
            SqlCommand command = new SqlCommand(commantString, conn);

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Telebe tapilmadi");
                ResetForm();
                return;
            }

            while (reader.Read())
            {
                txtName.Text = reader.GetString(1);
                txtSurname.Text = reader.GetString(2);
                txtEmail.Text = reader.GetString(3);
                dtpBirthday.Value = reader.GetDateTime(4);

                if (reader.GetBoolean(5))
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }

                //bool isMale =  ? : 
            }


            conn.Close();

        }


        private void ResetForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            dtpBirthday.Value = DateTime.Now.Date;
            rbFemale.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpBirthday.MaxDate = DateTime.Now;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string commandString = "INSERT INTO Students (Name, Surname, Email, Birthday, Gender) Values('"+ txtName.Text.Trim() + "', '" + txtSurname.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + dtpBirthday.Value + "', "+ (rbFemale.Checked ? 0 : 1 )+"); ";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Student Created");
                        ResetForm();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Enter ID and Update founded student");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string commandString = "UPDATE Students SET Name='" + txtName.Text.Trim() + "', Surname='" + txtSurname.Text.Trim() + "', Email='" + txtEmail.Text.Trim() + "', Birthday='" + dtpBirthday.Value + "', Gender=" + (rbFemale.Checked ? 0 : 1) + " WHERE Id="+ txtId.Text.Trim() +";";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Student Updated");
                        ResetForm();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Enter ID and Update founded student");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string commandString = "DELETE FROM Students WHERE Id=" + txtId.Text.Trim() + ";";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Student Deleted");
                        ResetForm();
                    }
                }
            }

        }
    }
}
