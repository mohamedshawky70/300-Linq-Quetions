using System.Numerics;

namespace _300_Linq_Quetions.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string BirthDate { get; set; }
        public string HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; } // Self Relationship
        public string PhotoPath { get; set; }

		public override string ToString()
		{
			return $"""
            Employee Details
            ================
            EmployeeID       | {EmployeeID}
            LastName         | {LastName ?? "N/A"}
            CFirstName       | {FirstName ?? "N/A"}
            Title            | {Title ?? "N/A"}
            TitleOfCourtesy  | {TitleOfCourtesy ?? "N/A"}
            BirthDate        | {BirthDate ?? "N/A"}
            Region           | {Region ?? "N/A"}
            Postal Code      | {PostalCode ?? "N/A"}
            Country          | {Country ?? "N/A"}
            HireDate         | {HireDate ?? "N/A"}
            City             | {City ?? "N/A"}
            Region           | {Region ?? "N/A"}
            PostalCode       | {PostalCode ?? "N/A"}
            Country          | {Country ?? "N/A"}
            HomePhone        | {HomePhone ?? "N/A"}
            Extension        | {Extension ?? "N/A"}
            Photo            | {Photo ?? "N/A"}
            Notes            | {Notes ?? "N/A"}
            ReportsTo        | {ReportsTo}
            PhotoPath        | {PhotoPath ?? "N/A"}
            ================
            """;
		}
	}
}
