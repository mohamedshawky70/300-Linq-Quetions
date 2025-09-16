namespace _300_Linq_Quetions.Entities
{
    public class Customer
    {
        public string CustomerID { get; set; }
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

        public override string ToString()
        {
			return $"""
            Customer Details
            ================
            Customer ID    | {CustomerID ?? "N/A"}
            Company Name   | {CompanyName ?? "N/A"}
            Contact Name   | {ContactName ?? "N/A"}
            Contact Title  | {ContactTitle ?? "N/A"}
            Address        | {Address ?? "N/A"}
            City           | {City ?? "N/A"}
            Region         | {Region ?? "N/A"}
            Postal Code    | {PostalCode ?? "N/A"}
            Country        | {Country ?? "N/A"}
            Phone          | {Phone ?? "N/A"}
            Fax            | {Fax ?? "N/A"}
            ================
            """;
		}
    }
}
