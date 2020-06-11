using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeList
    {
        Sergio,
        Salvador,
        Sofia,
        Susana,
        Sebastian
    }
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        public TypeList List { get; set; }
        [Required]
        public string Email { get; set; }
        [Display]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int Birthdate { get; set; }

    }
}