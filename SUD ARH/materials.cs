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
    public partial class materials : UserControl
    {
        public materials()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost;database = sud_arh;UID = root;password = 541123");
        MySqlCommand command;


        private void materials_Load(object sender, EventArgs e)
        {
            Actv();
        }

        public void Actv()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM materials";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            materialsDB.DataSource = table;
        }


        private void materialsDB_MouseClick(object sender, MouseEventArgs e)
        {
            Code.Text = materialsDB.CurrentRow.Cells[0].Value.ToString();
            Number.Text = materialsDB.CurrentRow.Cells[1].Value.ToString();
            Surname.Text = materialsDB.CurrentRow.Cells[2].Value.ToString();
            Name_matr.Text = materialsDB.CurrentRow.Cells[3].Value.ToString();
            Patronymic.Text = materialsDB.CurrentRow.Cells[4].Value.ToString();
            Type.Text = materialsDB.CurrentRow.Cells[5].Value.ToString();
            Year_of_inclusion_in_the_archive.Text = materialsDB.CurrentRow.Cells[6].Value.ToString();
            Storage_location.Text = materialsDB.CurrentRow.Cells[7].Value.ToString();
            matr_code.Text = materialsDB.CurrentRow.Cells[8].Value.ToString();
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
            string insertQuery = "INSERT INTO `materials`(Material_code, Material_number, Type , Surname, Name, Patronymic, Year_of_inclusion_in_the_archive, Storage_location, Accounting_for_the_issuance_of_documents_Code_of_the_applicant) VALUES " + "('" + Code.Text + "','" + Number.Text + "','" + Type.Text + "','" + Surname.Text + "','" + Name_matr.Text + "','" + Patronymic.Text + "','" + Year_of_inclusion_in_the_archive.Text + "','" + Storage_location.Text + "','" + matr_code.Text + "')";
            executeMyQuery(insertQuery);
            Actv();
        }

        private void Ismen_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `materials` SET Material_code=' " + Code.Text + "',Material_number='" + Number.Text + "',Type='" + Type.Text + "',Surname='" + Surname.Text + "',Name='" + Name_matr.Text + "',Patronymic= '" + Patronymic.Text + "',Year_of_inclusion_in_the_archive='" + Year_of_inclusion_in_the_archive.Text + "',Storage_location='" + Storage_location.Text + "',Accounting_for_the_issuance_of_documents_Code_of_the_applicant='" + matr_code.Text + "' WHERE Material_code=" + Code.Text;
            executeMyQuery(updateQuery);
            Actv();
        }
        private void Ydal_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM `materials` WHERE Material_code=" + Code.Text;
            executeMyQuery(deleteQuery);
            Actv();
        }
    }
}