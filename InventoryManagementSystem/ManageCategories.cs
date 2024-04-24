using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\InventoryManagementSystemDB.mdf;Integrated Security = True; Connect Timeout = 30");

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void ClearFields()
        {
            CategoryIdTextBox.Text = "";
            CategoryNameTextBox.Text = "";
        }

        public void Populate()
        {
            try
            {
                connection.Open();
                string myQuery = "SELECT * FROM [Categories]";
                SqlDataAdapter data = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataSet = new DataSet();
                data.Fill(dataSet);
                CategoriesDataGrid.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            if (CategoryIdTextBox.Text == ""
              || CategoryNameTextBox.Text == "")
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

                        string checkCategoryId = "SELECT COUNT(*) FROM [Categories] WHERE CategoryId = @CategoryId";

                        using (SqlCommand findCategory = new SqlCommand(checkCategoryId, connection))
                        {
                            findCategory.Parameters.AddWithValue("@CategoryId", CategoryIdTextBox.Text.Trim());
                            int count = (int)findCategory.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(CategoryIdTextBox.Text.Trim() + "alredy exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO [Categories]" +
     "(CategoryId, CategoryName)" + "VALUES(@CategoryId, @CategoryName)";


                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@CategoryId", CategoryIdTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text.Trim());


                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Category Added Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            if (CategoryIdTextBox.Text == ""
              || CategoryNameTextBox.Text == "")
            {
                MessageBox.Show("All fields are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Categoty: " + CategoryNameTextBox.Text + "?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string updateCategory = "UPDATE [Categories] SET CategoryId = '" + CategoryIdTextBox.Text + "', CategoryName = '" + CategoryNameTextBox.Text + "' WHERE CategoryId ='" + CategoryIdTextBox.Text + "'";

                        using (SqlCommand findCategory= new SqlCommand(updateCategory, connection))
                        {

                            using (SqlCommand cmd = new SqlCommand(updateCategory, connection))
                            {
                                cmd.Parameters.AddWithValue("@CategoryId", CategoryIdTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Category Updated Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {
            if (CategoryIdTextBox.Text == "")
            {
                MessageBox.Show("Category field is required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string myQuery = "DELETE FROM [Categories] WHERE CategoryId='" + CategoryIdTextBox.Text + "';";

                SqlCommand cmd = new SqlCommand(myQuery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfuly Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                Populate();
            }
        }

        private void ManageCategoriesClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoriesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = CategoriesDataGrid.Rows[e.RowIndex];
                CategoryIdTextBox.Text = row.Cells[0].Value.ToString();
                CategoryNameTextBox.Text = row.Cells[1].Value.ToString();

            }
        }
    }
}
