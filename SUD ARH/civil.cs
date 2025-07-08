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
    public partial class civil : UserControl
    {
        public civil()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;


        private void civil_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM civil";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            civilDB.DataSource = table;
        }


        private void civilDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = civilDB.CurrentRow.Cells[0].Value.ToString();
            Number.Text = civilDB.CurrentRow.Cells[1].Value.ToString();
            The_plaintiff.Text = civilDB.CurrentRow.Cells[2].Value.ToString();
            Accused.Text = civilDB.CurrentRow.Cells[3].Value.ToString();
            Defendant.Text = civilDB.CurrentRow.Cells[4].Value.ToString();
            Article.Text = civilDB.CurrentRow.Cells[5].Value.ToString();
            Decision.Text = civilDB.CurrentRow.Cells[6].Value.ToString();
            Year_of_inclusion_in_the_archive.Text = civilDB.CurrentRow.Cells[7].Value.ToString();
            Storage_location.Text = civilDB.CurrentRow.Cells[8].Value.ToString();
            civ_code.Text = civilDB.CurrentRow.Cells[9].Value.ToString();
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
            string insertQuery = "INSERT INTO `civil`(Code_of_civil_cases, Case_number, The_plaintiff, Accused, Defendant, Article, Decision, Year_of_inclusion_in_the_archive, Storage_location, Accounting_for_the_issuance_of_documents_Code_of_the_applicant) VALUES " + "('" + Code.Text + "','" + Number.Text + "','" + The_plaintiff.Text + "','" + Accused.Text + "','" + Defendant.Text + "','" + Article.Text + "','" + Decision.Text + "','" + Year_of_inclusion_in_the_archive.Text + "','" + Storage_location.Text + "','" + civ_code.Text + "')";
            executeMyQuery(insertQuery);
            Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `civil` SET Code_of_civil_cases=' " + Code.Text + "',Case_number='" + Number.Text + "',The_plaintiff='" + The_plaintiff.Text + "',Accused='" + Accused.Text + "',Defendant= '" + Defendant.Text + "',Article='" + Article.Text + "',Decision='" + Decision.Text + "',Year_of_inclusion_in_the_archive='" + Year_of_inclusion_in_the_archive.Text + "',Storage_location='" + Storage_location.Text + "',Accounting_for_the_issuance_of_documents_Code_of_the_applicant='" + civ_code.Text + "' WHERE Code_of_civil_cases=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `civil` WHERE Code_of_civil_cases=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }
    }
}