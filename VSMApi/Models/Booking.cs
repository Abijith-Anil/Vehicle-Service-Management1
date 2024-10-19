public class Booking
{
    public int? BookingId { get; set; }
    public int? VehicleId { get; set; }
    public int? ServiceId { get; set; }
    public DateTime BookingDate { get; set; }
    public TimeSpan BookingTime { get; set; }
}