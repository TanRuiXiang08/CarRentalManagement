namespace CarRentalManagement.Domain
{
    public class Vehicle :BaseDomainModel
    {
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
        public int Year { get; set; }
        public string? LicencePlateNumber { get; set; }
    
    }
}
