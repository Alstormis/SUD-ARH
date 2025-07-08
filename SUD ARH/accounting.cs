using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SUD_ARH
{
    public partial class accounting : UserControl
    {
        public accounting()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;


        private void accounting_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM accounting_for_the_issuance_of_documents";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            AccountingDB.DataSource = table;
        }


        private void AccountingDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = AccountingDB.CurrentRow.Cells[0].Value.ToString();
            Surname.Text = AccountingDB.CurrentRow.Cells[1].Value.ToString();
            Name_acco.Text = AccountingDB.CurrentRow.Cells[2].Value.ToString();
            Patronymic.Text = AccountingDB.CurrentRow.Cells[3].Value.ToString();
            Case_number.Text = AccountingDB.CurrentRow.Cells[4].Value.ToString();

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
            if(connection.State == ConnectionState.Open)
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

                if(command.ExecuteNonQuery() ==1)
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
            }finally
            {
                closeConnection();
            }
        }
        private void Dobav_Click(object sender, EventArgs e)
        {
           string insertQuery = "INSERT INTO `accounting_for_the_issuance_of_documents`(Code_of_the_applicant, Surname, Name, Patronymic, Case_number) VALUES ('" +Code.Text+ "','" +Surname.Text+ "','" +Name_acco.Text+ "','" + Patronymic.Text + "','" + Case_number.Text + "')";
           executeMyQuery(insertQuery);
           Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `accounting_for_the_issuance_of_documents` SET Code_of_the_applicant=' " + Code.Text + "',Surname='" + Surname.Text + "',Name='" + Name_acco.Text + "',Patronymic='" + Patronymic.Text + "',Case_number= '" + Case_number.Text + "' WHERE Code_of_the_applicant=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `accounting_for_the_issuance_of_documents` WHERE Code_of_the_applicant=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
