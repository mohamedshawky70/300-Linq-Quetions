namespace _300_Linq_Quetions.Entities
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

 
		public override string ToString()
		{
			return $"""
            Supplier Details
            ================
            SupplierID              | {SupplierID}
            CompanyName             | {CompanyName}
            Phone                   | {Phone}
            ContactName             | {ContactName}
            ContactTitle            | {ContactTitle}
            Address                 | {Address}
            City                    | {City}
            Region                  | {Region}
            PostalCode              | {PostalCode}
            Country                 | {Country}
            Fax                     | {Fax}
            HomePage                | {HomePage}
            ================
            """;
		}
	}
}
