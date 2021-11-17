using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Project5.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}
