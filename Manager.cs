namespace Project;

public class Manager : User
{
    public Manager(string name) : base(name) { }

    public override void ViewReservations(List<Reservation> reservations)
    {
        Console.WriteLine("Team Reservations:");
        foreach (var res in reservations)
        {
            Console.WriteLine(res);
        }
    }
}