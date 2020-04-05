using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IS_2
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dima\source\repos\IS_2\IS_2\students1.mdf;Integrated Security=True;Connect Timeout=30";
            
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            //SqlDataReader sqlReader = null;

            //SqlCommand command = new SqlCommand("SELECT * FROM [Студенты]", sqlConnection);

            //try
            //{
            //    sqlReader = await command.ExecuteReaderAsync();

            //    while (await sqlReader.ReadAsync()) 
            //    {
            //        listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) 
            //            + "     " + Convert.ToString(sqlReader["Фамилия"])
            //            + "     " + Convert.ToString(sqlReader["Имя"]) 
            //            + "     " + Convert.ToString(sqlReader["Отчество"])
            //            + "     " + Convert.ToString(sqlReader["Группа"]));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    if (sqlReader != null)
            //        sqlReader.Close();
            //}
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private async void buttonINSERT_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Студенты] (Фамилия, Имя, Отчество, Группа)VALUES(@Фамилия, @Имя, @Отчество, @Группа)", sqlConnection);

            if (labelINSERT.Visible)
                labelINSERT.Visible = false;


            if (!string.IsNullOrEmpty(textBox1INSERT.Text) && !string.IsNullOrWhiteSpace(textBox1INSERT.Text) &&
                !string.IsNullOrEmpty(textBox2INSERT.Text) && !string.IsNullOrWhiteSpace(textBox2INSERT.Text) &&
                !string.IsNullOrEmpty(textBox3INSERT.Text) && !string.IsNullOrWhiteSpace(textBox3INSERT.Text) &&
                !string.IsNullOrEmpty(textBox4INSERT.Text) && !string.IsNullOrWhiteSpace(textBox4INSERT.Text))
            {
                command.Parameters.AddWithValue("Фамилия", textBox1INSERT.Text);
                command.Parameters.AddWithValue("Имя", textBox2INSERT.Text);
                command.Parameters.AddWithValue("Отчество", textBox3INSERT.Text);
                command.Parameters.AddWithValue("Группа", textBox4INSERT.Text);

                await command.ExecuteNonQueryAsync();
            }
            else 
            {
                labelINSERT.Visible = true;

                labelINSERT.Text = "Поля 'Фамилия', 'Имя', 'Отчество', 'Группа' должны быть заполнены!";
            }
        }

        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Студенты]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"])
                        + "     " + Convert.ToString(sqlReader["Фамилия"])
                        + "     " + Convert.ToString(sqlReader["Имя"])
                        + "     " + Convert.ToString(sqlReader["Отчество"])
                        + "     " + Convert.ToString(sqlReader["Группа"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void buttonUPDATE_Click(object sender, EventArgs e)
        {
            if (labelUPDATE.Visible)
                labelUPDATE.Visible = false;


            if (!string.IsNullOrEmpty(textBox1UPDATE.Text) && !string.IsNullOrWhiteSpace(textBox1UPDATE.Text) &&
                !string.IsNullOrEmpty(textBox2UPDATE.Text) && !string.IsNullOrWhiteSpace(textBox2UPDATE.Text) &&
                !string.IsNullOrEmpty(textBox3UPDATE.Text) && !string.IsNullOrWhiteSpace(textBox3UPDATE.Text) &&
                !string.IsNullOrEmpty(textBox4UPDATE.Text) && !string.IsNullOrWhiteSpace(textBox4UPDATE.Text) &&
                !string.IsNullOrEmpty(textBox5UPDATE.Text) && !string.IsNullOrWhiteSpace(textBox5UPDATE.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Студенты] SET [Фамилия]=@Фамилия, [Имя]=@Имя, [Отчество]=@Отчество, [Группа]=@Группа WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id",textBox1UPDATE.Text);
                command.Parameters.AddWithValue("Фамилия", textBox2UPDATE.Text);
                command.Parameters.AddWithValue("Имя", textBox3UPDATE.Text);
                command.Parameters.AddWithValue("Отчество", textBox4UPDATE.Text);
                command.Parameters.AddWithValue("Группа", textBox5UPDATE.Text);

                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox1UPDATE.Text) && string.IsNullOrWhiteSpace(textBox1UPDATE.Text))
            {
                labelUPDATE.Visible = true;

                labelUPDATE.Text = "Id должен быть заполнен!";
            }
            else
            {
                labelUPDATE.Visible = true;

                labelUPDATE.Text = "Поля 'Id', 'Фамилия', 'Имя', 'Отчество', 'Группа' должны быть заполнены!";
            }
        }

        private async void button1DELETE_Click(object sender, EventArgs e)
        {
            if (labelDELETE.Visible)
                labelDELETE.Visible = false;


            if (!string.IsNullOrEmpty(textBox1DELETE.Text) && !string.IsNullOrWhiteSpace(textBox1DELETE.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Студенты] WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id",textBox1DELETE.Text);

                await command.ExecuteNonQueryAsync();
            }
            else 
            {
                labelDELETE.Visible = true;

                labelDELETE.Text = "Id должен быть заполнен!";
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Студенты][Группа] WHERE [Id]=@Id ", sqlConnection);

            command.Parameters.AddWithValue("Название", textBoxSearch.Text);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                listBox1.Items.Clear();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"])
                        + "     " + Convert.ToString(sqlReader["Фамилия"])
                        + "     " + Convert.ToString(sqlReader["Имя"])
                        + "     " + Convert.ToString(sqlReader["Отчество"])
                        + "     " + Convert.ToString(sqlReader["Группа"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
