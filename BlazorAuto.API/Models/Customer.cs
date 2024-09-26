namespace BlazorAuto.API.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
