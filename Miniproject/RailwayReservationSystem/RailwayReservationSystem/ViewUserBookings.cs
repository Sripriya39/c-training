using System;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
    public partial class Program
    {
        static void ViewUserBookings()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand viewuser = new SqlCommand("select * from Bookings where UserID = @UserID", con);
                viewuser.Parameters.AddWithValue("@UserID", loggedInUserId);
                using (SqlDataReader read = viewuser.ExecuteReader())
                {
                    if (!read.HasRows)
                    {
                        Console.WriteLine("You have no bookings.");
                        return;
                    }

                    Console.WriteLine("BookingID, TrainNo, SeatsBooked, BookingDate");
                    while (read.Read())
                    {
                        Console.WriteLine($"{read["BookingID"]}, {read["TrainNo"]}, {read["SeatsBooked"]}, {read["BookingDate"]}");
                    }
                }
            }
        }
    }
}