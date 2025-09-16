using System.Net;

namespace _300_Linq_Quetions.Entities
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

		public override string ToString()
		{
			return $"""
            OrderDetail Details
            ================
            OrderID              | {OrderID}
            ProductID            | {ProductID}
            UnitPrice            | {UnitPrice}
            Quantity             | {Quantity}
            Discount             | {Discount}
            ================
            """;
		}
	}
}
