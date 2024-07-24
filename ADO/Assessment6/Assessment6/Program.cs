using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADO
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
            SelectData();
            Console.Read();
        }

        private static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection("data source = ICS-LT-1S2RQ73\\SQLEXPRESS; initial catalog = EmployeeManagement;" +
               "User ID = sa; Password = Sri@priya03");
            con.Open();
            return con;
        }

        public static void InsertData()
        {
            using (SqlConnection con = getConnection())
            {
                string Empname;
                decimal Empsal;
                string Emptype;
                Console.WriteLine("enter Employee details");
                Empname = Console.ReadLine();
                Empsal = Convert.ToDecimal(Console.ReadLine());
                Emptype = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpName", Empname);
                cmd.Parameters.AddWithValue("@Empsal", Empsal);
                cmd.Parameters.AddWithValue("@Emptype", Emptype);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    Console.WriteLine("Insertion success");
                else
                    Console.WriteLine("Could not insert data");
            }
        }

        public static void SelectData()
        {
            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Details", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Empno: " + reader["Empno"].ToString());
                    Console.WriteLine("EmpName: " + reader["EmpName"].ToString());
                    Console.WriteLine("EmpSal: " + reader["EmpSal"].ToString());
                    Console.WriteLine("Emptype: " + reader["Emptype"].ToString());
              
                }
            }
        }
    }
}