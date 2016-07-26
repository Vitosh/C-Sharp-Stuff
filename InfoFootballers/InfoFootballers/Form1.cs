using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;    //Here is the SqlConnection

namespace InfoFootballers
{
    public partial class Form1 : Form
    {
        const string str_conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VitoshAcademyCom;Integrated Security=True";
        public List<int> int_id = new List<int>();
        public List<string> str_first_name = new List<string>();
        public List<string> str_last_name = new List<string>();
        public List<string> str_club = new List<string>();
        public List<string> str_city = new List<string>();
        public int counter = 0;

        public Form1()
        {
            InitializeComponent();

            SqlConnection my_connection = null;
            SqlCommand my_command = null;
            SqlDataReader my_reader = null;

            try
            {
                my_connection = new SqlConnection(str_conn);
                my_connection.Open();
                my_command = my_connection.CreateCommand();
                my_command.CommandText = "SELECT * FROM Footballers;";
                my_reader = my_command.ExecuteReader();

                while (my_reader.Read())
                {
                    int_id.Add(my_reader.GetInt32(0));
                    str_first_name.Add(my_reader.GetString(1));
                    str_last_name.Add(my_reader.GetString(2));
                    str_club.Add(my_reader.GetString(3));
                    str_city.Add(my_reader.GetString(4));
                    counter++;
                }

                lbl_id.Text = int_id[0].ToString();
                lbl_fn.Text = str_first_name[0].ToString();
                lbl_ln.Text = str_last_name[0].ToString();
                lbl_club.Text = str_club[0].ToString();
                lbl_city.Text = str_city[0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (my_reader!=null)
                {
                    my_reader.Close();
                }
                if (my_connection!=null)
                {
                    my_connection.Close();
                }
                counter = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vitoshAcademyComDataSet.Footballers' table. You can move, or remove it, as needed.
            this.footballersTableAdapter.Fill(this.vitoshAcademyComDataSet.Footballers);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(counter.ToString());
            if (counter >= int_id.Count-1)
            {
                lbl_info.Text = "No next...";
                return;
            }
            lbl_info.Text = "";
            counter++;

            lbl_id.Text = int_id[counter].ToString();
            lbl_fn.Text = str_first_name[counter];
            lbl_ln.Text = str_last_name[counter];
            lbl_club.Text = str_club[counter];
            lbl_city.Text = str_city[counter];
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (counter==0)
            {
                lbl_info.Text = "No previous...";
                return;
            }
            lbl_info.Text = "";
            counter--;

            lbl_id.Text = int_id[counter].ToString();
            lbl_fn.Text = str_first_name[counter];
            lbl_ln.Text = str_last_name[counter];
            lbl_club.Text = str_club[counter];
            lbl_city.Text = str_city[counter];
        }
    }
}
