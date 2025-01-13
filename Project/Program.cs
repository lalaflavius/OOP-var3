namespace Project;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        int roleOption;
        do
        {
            Console.WriteLine("Select your role (1-Employee, 2-Manager, 3-Administrator): ");
            roleOption = int.Parse(Console.ReadLine());
        } while (roleOption != 1 && roleOption != 2 && roleOption != 3);

        User user;
            if (roleOption == 1)
            {
                user = new Employee(userName);
            }
            else if (roleOption == 2)
            {
                user = new Manager(userName);
            }
            else
            {
                user = new Admin(userName);
            }
        

        ReservationManager manager = new ReservationManager();
        string option;

        do
        {
            Console.WriteLine("\n1. View Spots\n2. Make Reservation\n3. View Reservations\n4. Delete Reservation\n5. Exit");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter type (Office or Parking): ");
                    string type = Console.ReadLine();
                    manager.DisplaySpots(type);
                    break;

                case "2":
                    Console.WriteLine("Enter type (Office or Parking): ");
                    string resType = Console.ReadLine();
                    Console.WriteLine("Enter spot number: ");
                    int spot = int.Parse(Console.ReadLine());
                    manager.MakeReservation(resType, spot, user.Name);
                    break;

                case "3":
                    user.ViewReservations(manager.GetReservations());
                    break;

                case "4":
                    Console.WriteLine("Enter reservation ID: ");
                    int delId = int.Parse(Console.ReadLine());
                    bool canDeleteAll = user is Admin;
                    manager.DeleteReservation(delId, user.Name, canDeleteAll);
                    break;
            }
        } while (option != "5");
    }
}
