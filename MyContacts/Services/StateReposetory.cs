using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.Configuration;

namespace MyContacts
{
    class StateReposetory : IstateRepository
    {

        private string connectionStringState = "Data Source =.;Initial Catalog=Contact_DB;Integrated Security=true";
        public bool Delete(int id)
        {
            SqlConnection connection = new SqlConnection(connectionStringState);

            try
            {
                string query = "Delete From realestateFile where id=@ID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", id);
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






        public bool Insert(string codefile,int metraj, string address, string namemalek, int price, string mobile, string categoryname)
        {
            SqlConnection connection = new SqlConnection(connectionStringState);

            try
            {

                string query = "Insert into realestateFile(CodFile,metraj,Address,NameMalek,Price,Mobile,CategoryName) values (@CodFile,@metraj,@Address,@NameMalek,@Price,@Mobile,@CategoryName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codfile", codefile);
                command.Parameters.AddWithValue("@metraj", metraj);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@NameMalek", namemalek);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Mobile", mobile);

                command.Parameters.AddWithValue("@CategoryName", categoryname);
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

        public DataTable SearchFile(string parameter)
        {
            string query = "Select * From realestateFile where CodFile like @parameter or Address like @parameter or NameMalek like @parameter"; ;
            SqlConnection connection = new SqlConnection(connectionStringState);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;


        }

        public DataTable SearchParams(int param1, int param2)
        {

            string query = "SELECT * FROM realestateFile WHERE Price BETWEEN @param1 AND @param2;";


            SqlConnection connection = new SqlConnection(connectionStringState);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);



            adapter.SelectCommand.Parameters.AddWithValue("@param1", param1 );
            adapter.SelectCommand.Parameters.AddWithValue("@param2", param2 );

            DataTable data = new DataTable();
            adapter.Fill(data);


            return data;





        }



        public DataTable SelectAll()
        {
            string query = "Select * From realestateFile";
             
            SqlConnection connection = new SqlConnection(connectionStringState);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int id)
        {
            string query = "Select * From realestateFile where id =" + id;
            SqlConnection connection = new SqlConnection(connectionStringState);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int id, string codefile,int metraj, string address, string namemalek, int price, string mobile, string categoryname)
        {
            SqlConnection connection = new SqlConnection(connectionStringState);

            try
            {


                string query = "Update realestateFile Set CodFile=@CodFile,metraj=@metraj,Address=@Address,NameMalek=@NameMalek,Price=@Price,Mobile=@Mobile,CategoryName=@CategoryName where id=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                command.Parameters.AddWithValue("@Codfile", codefile);
                command.Parameters.AddWithValue("@metraj", metraj);

                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@NameMalek", namemalek);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Mobile", mobile);

                command.Parameters.AddWithValue("@CategoryName", categoryname);
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



        public DataTable SearchMetraj(int param1, int param2)
        {
            string query = "SELECT * FROM realestateFile WHERE metraj BETWEEN @param1 AND @param2;";


            SqlConnection connection = new SqlConnection(connectionStringState);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);



            adapter.SelectCommand.Parameters.AddWithValue("@param1", param1);
            adapter.SelectCommand.Parameters.AddWithValue("@param2", param2);

            DataTable data = new DataTable();
            adapter.Fill(data);


            return data;
        }
    }

}
