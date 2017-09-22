﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mybookstore.Models
{
    public class AuthorsModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(40,ErrorMessage = "Up to 40 characters only")]
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }

        [Display(Name = "Frist Name")]
        [MaxLength(20, ErrorMessage = "Up to 20 characters only")]
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(12, ErrorMessage = "Up to 12 characters only")]
        [Required(ErrorMessage = "Required")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [MaxLength(20, ErrorMessage = "Up to 20 characters only")]
        public string City { get; set; }

        [Display(Name = "State")]
        [MaxLength(2, ErrorMessage = "Up to 2 characters only")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        [MaxLength(5, ErrorMessage = "Up to 5 characters only")]
        public string Zip { get; set; }
    }
}