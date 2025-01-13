namespace Project;

public class Employee : User
{
    public Employee(string name) : base(name) { }

    public override void ViewReservations(List<Reservation> reservations)
    {
        Console.WriteLine("Your Reservations:");
        foreach (var res in reservations)
        {
            if (res.ReservedBy == Name)
            {
                Console.WriteLine(res);
            }
        }
    }
}