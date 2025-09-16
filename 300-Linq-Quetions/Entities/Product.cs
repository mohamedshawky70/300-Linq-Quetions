namespace _300_Linq_Quetions.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

		public override string ToString()
		{
			return $"""
            Product Details
            ================
            ProductName              | {ProductName}
            ProductID            | {ProductID}
            UnitPrice            | {UnitPrice}
            SupplierID             | {SupplierID}
            QuantityPerUnit             | {QuantityPerUnit}
            UnitPrice             | {UnitPrice}
            UnitsInStock             | {UnitsInStock}
            UnitsOnOrder             | {UnitsOnOrder}
            ReorderLevel             | {ReorderLevel}
            Discontinued             | {Discontinued}
            ================
            """;
		}
	}
}
