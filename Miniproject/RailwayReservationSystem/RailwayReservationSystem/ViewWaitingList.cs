using System;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
    public partial class Program
    {
        static void ViewWaitingList()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand viewwaitlist = new SqlCommand("Select * from WaitingList", con);
                using (SqlDataReader read = viewwaitlist.ExecuteReader())
                {
                    Console.WriteLine("WaitingID, UserID, TrainNo, SeatsRequested, RequestDate");
                    while (read.Read())
                    {
                        Console.WriteLine($"{read["WaitingID"]}, {read["UserID"]}, {read["TrainNo"]}, {read["SeatsRequested"]}, {read["RequestDate"]}");
                    }
                }
            }
        }
    }
}