namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public int VehicleID { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}