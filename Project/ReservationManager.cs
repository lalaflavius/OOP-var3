namespace Project;

public class ReservationManager
{
    private List<Reservation> reservations = new List<Reservation>();
    private int nextId = 1;

    public void DisplaySpots(string type)
    {
        Console.WriteLine($"{type} Spots:");
        for (int i = 1; i <= 10; i++)
        {
            var reserved = reservations.Exists(r => r.SpotNumber == i && r.Type == type);
            Console.WriteLine($"{type} Spot {i}: {(reserved ? "Reserved" : "Available")}");
        }
    }

    public void MakeReservation(string type, int spotNumber, string reservedBy)
    {
        if (reservations.Exists(r => r.SpotNumber == spotNumber && r.Type == type))
        {
            Console.WriteLine("Spot already reserved.");
        }
        else
        {
            reservations.Add(new Reservation { Id = nextId++, SpotNumber = spotNumber, Type = type, ReservedBy = reservedBy });
            Console.WriteLine("Reservation successful.");
        }
    }

    public List<Reservation> GetReservations()
    {
        return reservations;
    }

    public Reservation GetReservationById(int id)
    {
        return reservations.Find(r => r.Id == id);
    }

    public void DeleteReservation(int id, string reservedBy, bool canDeleteAll)
    {
        var res = reservations.Find(r => r.Id == id);
        if (res != null && (res.ReservedBy == reservedBy || canDeleteAll))
        {
            reservations.Remove(res);
            Console.WriteLine("Reservation deleted.");
        }
        else
        {
            Console.WriteLine("Reservation not found or permission denied.");
        }
    }
}