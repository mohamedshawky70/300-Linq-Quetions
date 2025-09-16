using System.Diagnostics.Metrics;

namespace _300_Linq_Quetions.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipperID { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

		public override string ToString()
        {
            return $"""
            Order Details
            ================
            OrderID              | {OrderID}
            CustomerID           | {CustomerID}
            EmployeeID           | {EmployeeID}
            OrderDate            | {OrderDate}
            RequiredDate         | {RequiredDate}
            ShippedDate          | {ShippedDate}
            ShipperID            | {ShipperID}
            Freight              | {Freight}
            ShipName             | {ShipName ?? "N/A"}
            ShipAddress          | {ShipAddress ?? "N/A"}
            ShipCity             | {ShipCity ?? "N/A"}
            ShipRegion           | {ShipRegion ?? "N/A"}
            ShipPostalCode       | {ShipPostalCode ?? "N/A"}
            ShipCountry          | {ShipCountry ?? "N/A"}
            ================
            """;
        }
    }
}
