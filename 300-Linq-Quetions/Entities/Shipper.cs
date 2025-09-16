namespace _300_Linq_Quetions.Entities
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

		public override string ToString()
		{
			return $"""
            Shipper Details
            ================
            ShipperID              | {ShipperID}
            CompanyName            | {CompanyName}
            Phone                  | {Phone}
            ================
            """;
		}
	}
}
