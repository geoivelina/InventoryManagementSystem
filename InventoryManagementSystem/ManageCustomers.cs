using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\InventoryManagementSystemDB.mdf;Integrated Security = True; Connect Timeout = 30");

        private void CustomersClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearFields()
        {
            CustomerIdTextBox.Text = "";
            CustomerNameTextBox.Text = "";
            CustomerPhoneTextBox.Text = "";
        }

        public void Populate()
        {
            try
            {
                connection.Open();
                string myQuery = "SELECT * FROM [Customers]";
                SqlDataAdapter data = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataSet = new DataSet();
                data.Fill(dataSet);
                CustomersDataGrid.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == ""
               || CustomerPhoneTextBox.Text == ""
               || CustomerIdTextBox.Text == "")
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

                        string checkCustomerId = "SELECT COUNT(*) FROM [Customers] WHERE CustomerId = @CustomerId";

                        using (SqlCommand findCustomer = new SqlCommand(checkCustomerId, connection))
                        {
                            findCustomer.Parameters.AddWithValue("@CustomerId", CustomerIdTextBox.Text.Trim());
                            int count = (int)findCustomer.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(CustomerIdTextBox.Text.Trim() + "alredy exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO [Customers]" +
     "(CustomerId, CustomerName, CustomerPhone)" + "VALUES(@CustomerId, @CustomerName, @CustomerPhone)";


                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@CustomerId", CustomerIdTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhoneTextBox.Text.Trim());


                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Customer Added Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {

            if (CustomerIdTextBox.Text == "")
            {
                MessageBox.Show("CustomerId field is required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string myQuery = "DELETE FROM [Customers] WHERE CustomerId='" + CustomerIdTextBox.Text + "';";

                SqlCommand cmd = new SqlCommand(myQuery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfuly Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                Populate();
            }
        }

        private void CustomersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = CustomersDataGrid.Rows[e.RowIndex];
                CustomerIdTextBox.Text = row.Cells[0].Value.ToString();
                CustomerNameTextBox.Text = row.Cells[1].Value.ToString();
                CustomerPhoneTextBox.Text = row.Cells[2].Value.ToString();

            }
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == ""
               || CustomerPhoneTextBox.Text == ""
               || CustomerIdTextBox.Text == "")
            {
                MessageBox.Show("All fields are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Customer: " + CustomerNameTextBox.Text + "?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string updateUser = "UPDATE [Customers] SET CustomerId = '" + CustomerIdTextBox.Text + "', CustomerName = '" + CustomerNameTextBox.Text + "', CustomerPhone = '" + CustomerPhoneTextBox.Text + "' WHERE CustomerId ='" + CustomerIdTextBox.Text + "'";

                        using (SqlCommand findEmployee = new SqlCommand(updateUser, connection))
                        {

                            using (SqlCommand cmd = new SqlCommand(updateUser, connection))
                            {
                                cmd.Parameters.AddWithValue("@CustomerId", CustomerIdTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhoneTextBox.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Customer Updated Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
