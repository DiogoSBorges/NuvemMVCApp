using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NuvemMVCApp.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required, Display(Name ="Name")]
        public string name { get; set; }

        [Required, Display(Name = "Age")]
        public int age { get; set; }

        [Required, Display(Name = "Birth Date"), DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime birthDate { get; set; }
    }
}
