using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace MyContacts.Services
{
    class ContactsReposetory : IContactRepository
    {

        private string connectionString = "Data Source =.;Initial Catalog=Contact_DB;Integrated Security=true";



        public bool Delete(int contactId)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            try
            {
                string query = "Delete From MyContacts where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }

        public bool Insert(string name, string Family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            try
            {
                string query = "Insert Into MyContacts(Name,Family,Email,Age,Mobile,Address) values (@Name,@Family,@Email,@Age,@Mobile,@Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", Family);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                connection.Close();

            }





        }

        public DataTable SelectAll()
        {

            string query = "Select * From MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SelectRow(int contactId)
        {
            string query = "Select * From MyContacts where ContactID=" + contactId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable Serach(string parameter)
        {

            string query = "Select * From MyContacts where Name like @parameter or Family like @parameter ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;


        }

        public bool update(int contactId, string name, string Family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            try
            {


                string query = "Update MyContacts Set Name=@Name,Mobile=@Mobile,Family=@Family,Email=@Email,Age=@Age,Address=@Address where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", Family);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
