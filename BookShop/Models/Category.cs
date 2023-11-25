using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		[DisplayName("Display Order Of Category")]
		[Range(1,100)]
		public int DisplayOrder { get; set; }
	}
}
