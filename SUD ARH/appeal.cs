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
    public partial class appeal : UserControl
    {
        public appeal()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;


        private void appeal_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM appeal";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            appealDB.DataSource = table;
        }


        private void appealDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = appealDB.CurrentRow.Cells[0].Value.ToString();
            Number.Text = appealDB.CurrentRow.Cells[1].Value.ToString();
            Surname.Text = appealDB.CurrentRow.Cells[2].Value.ToString();
            Name_app.Text = appealDB.CurrentRow.Cells[3].Value.ToString();
            Patronymic.Text = appealDB.CurrentRow.Cells[4].Value.ToString();
            address.Text = appealDB.CurrentRow.Cells[5].Value.ToString();
            phone.Text = appealDB.CurrentRow.Cells[6].Value.ToString();
            Year_of_inclusion_in_the_archive.Text = appealDB.CurrentRow.Cells[7].Value.ToString();
            Storage_location.Text = appealDB.CurrentRow.Cells[8].Value.ToString();
            Ap_code.Text = appealDB.CurrentRow.Cells[9].Value.ToString();
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
            string insertQuery = "INSERT INTO `appeal`(Appeal_code, Number_appeal, Surname, Name, Patronymic, Residential_address, phone, Year_of_inclusion_in_the_archive, Storage_location, Accounting_for_the_issuance_of_documents_Code_of_the_applicant) VALUES " + "('" + Code.Text + "','" + Number.Text + "','" + Surname.Text + "','" + Name_app.Text + "','" + Patronymic.Text + "','" + address.Text + "','" + phone.Text + "','" + Year_of_inclusion_in_the_archive.Text + "','" + Storage_location.Text + "','" + Ap_code.Text + "')";
            executeMyQuery(insertQuery);
            Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `appeal` SET Appeal_code=' " + Code.Text + "',Number_appeal='" + Number.Text + "',Surname='" + Surname.Text + "',Name='" + Name_app.Text + "',Patronymic= '" + Patronymic.Text + "',Residential_address='" + address.Text + "',phone='" + phone.Text + "',Year_of_inclusion_in_the_archive='" + Year_of_inclusion_in_the_archive.Text + "',Storage_location='" + Storage_location.Text + "',Accounting_for_the_issuance_of_documents_Code_of_the_applicant='" + Ap_code.Text + "' WHERE Appeal_code=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `appeal` WHERE Appeal_code=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }
    }
}