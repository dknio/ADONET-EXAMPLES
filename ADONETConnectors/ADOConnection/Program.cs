using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADONETConnectors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SimpleConexion
            /*

            string conString = @"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True");
            string querystring = "Select * from AuthorISBN";
            conn.Open();
            SqlCommand cmd = new SqlCommand(querystring, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
            }
            conn.Close();
            */
            #endregion

            #region CrearDB
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=Master;Integrated Security=True");
            string query = "Create Database ComputerShop";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Sucessfully!");
            }
            catch (SqlException e)
            {

                Console.WriteLine("Error Generate. Details:" + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region RenameDB
            /*
           SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=Master;Integrated Security=True");
           string query = "Alter DATABASE ComputerShop MODIFY NAME = MobileShop";
           SqlCommand cmd = new SqlCommand(query, conn);
           try
           {
               conn.Open();
               cmd.ExecuteNonQuery();
               Console.WriteLine("Database Modified Sucessfully!");
           }
           catch (SqlException e)
           {

               Console.WriteLine("Error Generate. Details:" + e.ToString());
           }
           finally
           {
               conn.Close();
               Console.ReadKey();
           }
           */
            #endregion

            #region EliminarDB
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            string query = "DROP DATABASE MobileShop";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Deleted Sucessfully!");
            }
            catch (SqlException e)
            {

                Console.WriteLine("Error Generate. Details:" + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region CreateTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS; Initial Catalog=ComputerShop; Integrated Security=TRUE");
            string query =
                @"CREATE TABLE dbo.Products
(
ID int IDENTITY(1,1) NOT NULL,
Name nvarchar(50) NULL,
Price nvarchar(50) NULL,
Date datetime NULL,
CONSTRAINT pk_id PRIMARY KEY(ID)
);";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Sucessfully");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region RenameTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query = @"EXEC sp_rename 'Products','Accesories'";
            SqlCommand cmd = new SqlCommand(query,conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Renamed Sucessfully");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region addColumnTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=TRUE");
            string query = "ALTER TABLE Accesories ADD Stock nvarchar(50)";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Modfy sucessfully!");
            }
            catch (Exception e)
            {

                Console.WriteLine("error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region AlteringColumntable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query = 
                "ALTER TABLE Accesories ALTER COLUMN Stock int";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Column Altered Successfully");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region DropColumnTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query =
                "ALTER TABLE Accesories DROP COLUMN Stock";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Column Drop sucessfully");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region DropTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query = @"DROP TABLE Accesories";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table deleted!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString()); ;
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region InsertRecordsTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=true");
            string query1 = @"CREATE TABLE dbo.Products
(
Name nvarchar (50) NOT NULL,
Price nvarchar (50) NULL,
Date datetime NOT NULL
);";

            string query2 = "INSERT INTO dbo.Products (Name, Price, Date) values ('Led Screen', '$127', 'January 2017')";
            SqlCommand cmdq1 = new SqlCommand(query1, conn);
            SqlCommand cmdq2 = new SqlCommand(query2, conn);
            try
            {
                conn.Open();
                cmdq1.ExecuteNonQuery();
                Console.WriteLine("Table Created Sucessfully");
                Console.WriteLine();
                cmdq2.ExecuteNonQuery();
                Console.WriteLine("Lines added Successfully!");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region  InsertRecordsParametrize
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query = "INSERT INTO dbo.Products (Name, Price, Date) values (@Name, @Price, @Date)";
            SqlCommand cmd = new SqlCommand(query, conn);

            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@Name", "USB Keyboiard");
            cmd.Parameters.AddWithValue("@Price","$20");
            cmd.Parameters.AddWithValue("@Date","25 May 2017");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Sucessfully!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region CopyToAnotherTable
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query1 = @"CREATE TABLE Items(Name varchar(50) NULL, Price nvarchar(50) NULL, Date datetime NULL,);";
            string query2 = "INSERT INTO Items(Name, Price, Date) SELECT Name, Price, Date FROM dbo.Products";
            SqlCommand cmdq1 = new SqlCommand(query1, conn);
            SqlCommand cmdq2 = new SqlCommand(query2,conn);
            try
            {
                conn.Open();
                cmdq1.ExecuteNonQuery();
                Console.WriteLine("Table Created sucessfully");
                cmdq2.ExecuteNonQuery();
                Console.WriteLine("Registers copied into Items");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey(); 
            }
            */
            #endregion

            #region CreatingStoreProcedure
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query =
                @"
CREATE PROCEDURE Insert_Record
(
@Name VARCHAR(50),
@Price VARCHAR(50),
@Date datetime
)
AS
INSERT INTO Products(Name,Price,Date) Values (@Name,@Price,@Date)";

            SqlCommand cmd = new SqlCommand(query,conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Store Procedure added!");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region ListStoreProcedureCreated
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query = @"select SPECIFIC_NAME from ComputerShop.information_schema.routines where routine_type = 'PROCEDURE'";
            SqlCommand cmd = new SqlCommand(query,conn);

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["SPECIFIC_NAME"].ToString());
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region InsertRecordStoreProcedure
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert_Record", conn);

            try
            {
                conn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "SSD Disk"));
                cmd.Parameters.Add(new SqlParameter("@Price","$300"));
                cmd.Parameters.Add(new SqlParameter("@Date", "August 25 14"));
                int i  = cmd.ExecuteNonQuery();
                if (i >0)
                {
                    Console.WriteLine("Records Inserted Sucessfully");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            */
            #endregion

            #region RetrieveRecordStoreProcedure
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query1 = @"CREATE PROCEDURE Retrieve_Record_Proc(@Name varchar(50)) AS SELECT Name,Price,date FROM dbo.Products where Name=@Name";

            try
            {
                conn.Open();
                SqlCommand cmdq1 = new SqlCommand(query1, conn);
                cmdq1.ExecuteNonQuery();
                Console.WriteLine("Store Procedure added . . .");
                Console.WriteLine("Press enter to continue\n");
                Console.ReadKey();

                SqlCommand cmd = new SqlCommand("Retrieve_Record_Proc", conn);
                cmd.Parameters.Add(new SqlParameter("@Name", "Led Screen"));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("Product Name: " + dr[0].ToString());
                    Console.WriteLine("Price: " + dr[1].ToString());
                    Console.WriteLine("Date: " + dr[2].ToString());
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.WriteLine("\n--Press enter to finish--");
                Console.ReadKey();
            }
            */
            #endregion

            #region Data_Set_Example
            string conString = @"Data Source=DESKTOP-S1HB38D\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True";
            string queryString = "SELECT * FROM Items";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Items");
            Console.WriteLine(ds.GetXml());
            Console.ReadKey();
            #endregion
        }
    }
}
