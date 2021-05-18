using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace DotByDotProj.Models
{
    public class ProductTypeViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Types { get; set; }
        public string ProductType { get; set; }
    }

}
