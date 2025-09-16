using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;

namespace _300_Linq_Quetions.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

		public override string ToString()
		{
			return $"""
            Category Details
            ================
            Category ID    | {CategoryID  }
            Category Name  | {CategoryName ?? "N/A"}
            Description    | {Description ?? "N/A"}
            ================
            """;
		}
	}
}
