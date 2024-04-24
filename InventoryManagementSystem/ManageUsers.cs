using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class IMSForm : Form
    {
        public IMSForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\InventoryManagementSystemDB.mdf;Integrated Security = True; Connect Timeout = 30");

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Populate()
        {
            try
            {
                connection.Open();
                string myQuery = "SELECT * FROM [User]";
                SqlDataAdapter data = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataSet = new DataSet();
                data.Fill(dataSet);
                UsersForm.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {


            if (UserNameTextBox.Text == ""
                || FullNameTextBox.Text == ""
                || PasswordTextBox.Text == ""
                || PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("All fields are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string checkUserName = "SELECT COUNT(*) FROM [User] WHERE UserName = @UserName";

                        using (SqlCommand findEmployee = new SqlCommand(checkUserName, connection))
                        {
                            findEmployee.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
                            int count = (int)findEmployee.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(UserNameTextBox.Text.Trim() + "alredy exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO [User]" +
     "(UserName, UserFullName, UserPassword,UserPhoneNumber)" + "VALUES(@UserName, @UserFullName, @UserPassword, @UserPhoneNumber)";


                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@UserFullName", FullNameTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@UserPassword", PasswordTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@UserPhoneNumber", PhoneNumberTextBox.Text.Trim());


                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("User Added Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                        Populate();
                    }

                }

            }
        }

        private void IMSForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("UserName field is required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string myQuery = "DELETE FROM [User] WHERE UserName='" + UserNameTextBox.Text + "';";

                SqlCommand cmd = new SqlCommand(myQuery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfuly Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                Populate();
            }
        }

        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = UsersForm.Rows[e.RowIndex];
                UserNameTextBox.Text = row.Cells[0].Value.ToString();
                FullNameTextBox.Text = row.Cells[1].Value.ToString();
                PasswordTextBox.Text = row.Cells[2].Value.ToString();
                PhoneNumberTextBox.Text = row.Cells[3].Value.ToString();

            }
        }

        private void ClearFields()
        {
            UserNameTextBox.Text = "";
            FullNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == ""
               || FullNameTextBox.Text == ""
               || PasswordTextBox.Text == ""
               || PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("All fields are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE User: " + UserNameTextBox.Text + "?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string updateUser = "UPDATE [User] SET UserName = '"+UserNameTextBox.Text+"', UserFullName = '"+FullNameTextBox.Text+"', UserPassword = '"+PasswordTextBox.Text+"', UserPhoneNumber = '"+PhoneNumberTextBox.Text+"' WHERE UserName ='"+UserNameTextBox.Text+"'";

                        using (SqlCommand findEmployee = new SqlCommand(updateUser, connection))
                        {

                            using (SqlCommand cmd = new SqlCommand(updateUser, connection))
                            {
                                cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@UserFullName", FullNameTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@UserPassword", PasswordTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@UserPhoneNumber", PhoneNumberTextBox.Text.Trim());


                                cmd.ExecuteNonQuery();
                                                             MessageBox.Show("User Updated Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                        Populate();
                    }

                }

            }

        }
    }
}
