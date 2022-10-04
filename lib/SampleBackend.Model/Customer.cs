namespace SampleBackend.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? VatNumber { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}