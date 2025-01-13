namespace Project;

public class Admin : User
{
    public Admin(string name) : base(name) { }

    public override void ViewReservations(List<Reservation> reservations)
    {
        Console.WriteLine("All Reservations:");
        foreach (var res in reservations)
        {
            Console.WriteLine(res);
        }
    }

    public void EditReservation(Reservation res, int newSpotNumber)
    {
        res.SpotNumber = newSpotNumber;
        Console.WriteLine("Reservation modified by Administrator.");
    }
}