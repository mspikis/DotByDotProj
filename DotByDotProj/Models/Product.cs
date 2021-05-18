using System;
using System.ComponentModel.DataAnnotations;

namespace DotByDotProj.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public decimal Price { get; set; }
    }
}

