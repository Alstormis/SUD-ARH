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
    public partial class complaints : UserControl
    {
        public complaints()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;


        private void complaints_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM complaints";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            complaintsDB.DataSource = table;
        }


        private void complaintsDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = complaintsDB.CurrentRow.Cells[0].Value.ToString();
            Number.Text = complaintsDB.CurrentRow.Cells[1].Value.ToString();
            Surname.Text = complaintsDB.CurrentRow.Cells[2].Value.ToString();
            Name_com.Text = complaintsDB.CurrentRow.Cells[3].Value.ToString();
            Patronymic.Text = complaintsDB.CurrentRow.Cells[4].Value.ToString();
            Article.Text = complaintsDB.CurrentRow.Cells[5].Value.ToString();
            Year_of_inclusion_in_the_archive.Text = complaintsDB.CurrentRow.Cells[6].Value.ToString();
            Storage_location.Text = complaintsDB.CurrentRow.Cells[7].Value.ToString();
            com_code.Text = complaintsDB.CurrentRow.Cells[8].Value.ToString();
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
            string insertQuery = "INSERT INTO `complaints`(Complaint_code, Complaint_number, Surname, Name, Patronymic, Article, Year_of_inclusion_in_the_archive, Storage_location, Accounting_for_the_issuance_of_documents_Code_of_the_applicant) VALUES " + "('" + Code.Text + "','" + Number.Text + "','" + Surname.Text + "','" + Name_com.Text + "','" + Patronymic.Text + "','" + Article.Text + "','"  + Year_of_inclusion_in_the_archive.Text + "','" + Storage_location.Text + "','" + com_code.Text + "')";
            executeMyQuery(insertQuery);
            Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `complaints` SET Complaint_code=' " + Code.Text + "',Complaint_number='" + Number.Text + "',Surname='" + Surname.Text + "',Name='" + Name_com.Text + "',Patronymic= '" + Patronymic.Text + "',Article='" + Article.Text + "',Year_of_inclusion_in_the_archive='" + Year_of_inclusion_in_the_archive.Text + "',Storage_location='" + Storage_location.Text + "',Accounting_for_the_issuance_of_documents_Code_of_the_applicant='" + com_code.Text + "' WHERE Complaint_code=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `complaints` WHERE Complaint_code=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }
    }
}