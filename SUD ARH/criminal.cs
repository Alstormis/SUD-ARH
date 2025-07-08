using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SUD_ARH
{
    public partial class criminal : UserControl
    {
        public criminal()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;


        private void criminal_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM criminal";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            criminalDB.DataSource = table;
        }


        private void criminalDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = criminalDB.CurrentRow.Cells[0].Value.ToString();
            Number.Text = criminalDB.CurrentRow.Cells[1].Value.ToString();
            Surname.Text = criminalDB.CurrentRow.Cells[2].Value.ToString();
            Name_cr.Text = criminalDB.CurrentRow.Cells[3].Value.ToString();
            Patronymic.Text = criminalDB.CurrentRow.Cells[4].Value.ToString();
            Article.Text = criminalDB.CurrentRow.Cells[5].Value.ToString();
            Decision.Text = criminalDB.CurrentRow.Cells[6].Value.ToString();
            Year_of_inclusion_in_the_archive.Text = criminalDB.CurrentRow.Cells[7].Value.ToString();
            Storage_location.Text = criminalDB.CurrentRow.Cells[8].Value.ToString();
            Cr_code.Text = criminalDB.CurrentRow.Cells[9].Value.ToString();
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        private void Dobav_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `criminal`(Criminal_case_code, Case_number, Surname, Name, Patronymic, Article, Decision, Year_of_inclusion_in_the_archive, Storage_location, Accounting_for_the_issuance_of_documents_Code_of_the_applicant) VALUES " + "('" + Code.Text + "','" + Number.Text + "','" + Surname.Text + "','" + Name_cr.Text + "','" + Patronymic.Text + "','" + Article.Text + "','" + Decision.Text + "','" + Year_of_inclusion_in_the_archive.Text + "','" + Storage_location.Text + "','" + Cr_code.Text + "')";
            executeMyQuery(insertQuery);
            Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `criminal` SET Criminal_case_code=' " + Code.Text + "',Case_number='" + Number.Text + "',Surname='" + Surname.Text + "',Name='" + Name_cr.Text + "',Patronymic= '" + Patronymic.Text + "',Article='" + Article.Text + "',Decision='" + Decision.Text + "',Year_of_inclusion_in_the_archive='" + Year_of_inclusion_in_the_archive.Text + "',Storage_location='" + Storage_location.Text + "',Accounting_for_the_issuance_of_documents_Code_of_the_applicant='" + Cr_code.Text + "' WHERE Criminal_case_code=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `criminal` WHERE Criminal_case_code=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }
    }
}