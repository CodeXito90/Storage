using Humanizer;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Server;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    // Keynotes: Common Data Annotations
    //[Required]: Ensures the field is not empty.
    //[StringLength(max)]: Limits the length of a string field.
    //[Range(min, max)]: Sets a range of valid values.
    //[EmailAddress]: Ensures the string is a valid email format.
    //[Phone]: Validates a phone number format.
    //[RegularExpression]: Allows complex pattern matching using regular expressions.

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name can't be longer than 100 characters.")]
        public string? Name { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime Orderdate { get; set; }
        public string? Category { get; set; }
        public string? Shelf { get; set; }

        [Range(1, 1000, ErrorMessage = "Order quantity must be between 1 and 1000.")]
        public int Count { get; set; }
        public string? Description { get; set; }

    }
}
