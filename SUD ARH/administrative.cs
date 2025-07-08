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
    public partial class administrative : UserControl
    {
        public administrative()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;

    
        private void administrative_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM administrative";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            adminDB.DataSource = table;
        }


       private void adminDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = adminDB.CurrentRow.Cells[0].Value.ToString();
            Number.Text = adminDB.CurrentRow.Cells[1].Value.ToString();
            Surname.Text = adminDB.CurrentRow.Cells[2].Value.ToString();
            Name_adm.Text = adminDB.CurrentRow.Cells[3].Value.ToString();
            Patronymic_adm.Text = adminDB.CurrentRow.Cells[4].Value.ToString();
            Article.Text = adminDB.CurrentRow.Cells[5].Value.ToString();
            Decision.Text = adminDB.CurrentRow.Cells[6].Value.ToString();
            Year_of_inclusion_in_the_archive.Text = adminDB.CurrentRow.Cells[7].Value.ToString();
            Storage_location.Text = adminDB.CurrentRow.Cells[8].Value.ToString();
            Ac_code.Text = adminDB.CurrentRow.Cells[9].Value.ToString();
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
            string insertQuery = "INSERT INTO `administrative`(Code_of_administrative_proceedings, Case_number, Surname, Name, Patronymic, Article, Decision, Year_of_inclusion_in_the_archive, Storage_location, Accounting_for_the_issuance_of_documents_Code_of_the_applicant) VALUES " + "('" + Code.Text + "','" + Number.Text + "','" + Surname.Text + "','" + Name_adm.Text + "','" + Patronymic_adm.Text + "','" + Article.Text + "','" + Decision.Text + "','" + Year_of_inclusion_in_the_archive.Text + "','" + Storage_location.Text + "','" + Ac_code.Text + "')";
            executeMyQuery(insertQuery);
            Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `administrative` SET Code_of_administrative_proceedings=' " + Code.Text + "',Case_number='" + Number.Text + "',Surname='" + Surname.Text + "',Name='" + Name_adm.Text + "',Patronymic= '" + Patronymic_adm.Text + "',Article='" + Article.Text + "',Decision='" + Decision.Text + "',Year_of_inclusion_in_the_archive='" + Year_of_inclusion_in_the_archive.Text + "',Storage_location='" + Storage_location.Text + "',Accounting_for_the_issuance_of_documents_Code_of_the_applicant='" + Ac_code.Text + "' WHERE Code_of_administrative_proceedings=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `administrative` WHERE Code_of_administrative_proceedings=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }
    }
}