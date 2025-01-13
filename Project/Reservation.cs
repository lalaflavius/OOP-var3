namespace Project;

public class Reservation
{
    public int Id { get; set; }
    public int SpotNumber { get; set; }
    public string Type { get; set; } // "Office" or "Parking"
    public string ReservedBy { get; set; }

    public override string ToString()
    {
        return $"{Type} Spot {SpotNumber} reserved by {ReservedBy}";
    }
}