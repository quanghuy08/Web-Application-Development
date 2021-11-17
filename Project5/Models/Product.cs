
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Project5.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Unit { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public Category Category { get; set; }
    }
}
