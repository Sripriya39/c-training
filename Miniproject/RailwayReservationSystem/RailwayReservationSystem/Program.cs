using System;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
   public  partial class Program
    {
        static string connectionString = "Server=ICS-LT-1S2RQ73\\SQLEXPRESS; Database=RailwayReservationDB; User Id=sa; Password=Sri@priya03;";


        static int loggedInUserId;
        static string loggedInUserRole;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello!! Welcome to  the IRCTC ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("you entered Wrong choice, please try again with correct choice.");
                        break;
                }
            }
        }

        static void Login()
        {
            Console.Write("Give Username to continue : ");
            string username = Console.ReadLine();
            Console.Write("Give Password: ");
            string password = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserId, Role from Users where UserName = @UserName AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    loggedInUserId = (int)read["UserId"];
                    loggedInUserRole = (string)read["Role"];
                    read.Close();

                    if (loggedInUserRole == "Admin")
                    {
                        AdminMenu();
                    }
                    else
                    {
                        UserMenu();
                    }
                }
                else
                {
                    Console.WriteLine("You Entered Invalid username / password.");
                }
            }
        }

        static void Register()
        {
            Console.Write("Give Username to continue: ");
            string username = Console.ReadLine();
            Console.Write("Give Password: ");
            string password = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, Password, Role) values (@UserName, @Password, 'User')", con);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Your Registration is successful!! And now you can login.");
            }
        }

        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. View Trains");
                Console.WriteLine("3. View Bookings");
                Console.WriteLine("4. View Cancellations");
                Console.WriteLine("5. View Waiting List");
                Console.WriteLine("6. Logout");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTrain();
                        break;
                    case 2:
                        ViewTrains();
                        break;
                    case 3:
                        ViewBookings();
                        break;
                    case 4:
                        ViewCancellations();
                        break;
                    case 5:
                        ViewWaitingList();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("User Menu");
                Console.WriteLine("1. Search Trains");
                Console.WriteLine("2. View Trains");
                Console.WriteLine("3. Book Ticket");
                Console.WriteLine("4. Cancel Ticket");
                Console.WriteLine("5. View My Bookings");
                Console.WriteLine("6. View Waiting List");
                Console.WriteLine("7. Logout");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SearchTrains();
                        break;
                    case 2:
                        ViewTrains();
                        break;
                    case 3:
                        BookTicket();
                        break;
                    case 4:
                        CancelTicket();
                        break;
                    case 5:
                        ViewUserBookings();
                        break;
                    case 6:
                        ViewWaitingList();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
