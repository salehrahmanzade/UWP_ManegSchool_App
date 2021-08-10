using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Data
{
   public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string fathersName { get; set; }

        [MaxLength(50)]
        public string CodeSenad { get; set; }

        public bool ISForeignCitizens { get; set; }

        public bool ISReligionShia { get; set; }

        [MaxLength(50)]
        public string CodeForeign { get; set; }

        [MaxLength(50)]
        public string CodePost { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string FathersEducation { get; set; }

        [MaxLength(50)]
        public string MothersEducation { get; set; }

        [MaxLength(10)]
        public string NumberOfFamillyMembers { get; set; }

        [MaxLength(50)]
        public string EconomicStatusOfTheFamily { get; set; }

        [MaxLength(50)]
        public string StudentsPhoneNumber { get; set; }

        [MaxLength(50)]
        public string FathersPhoneNumber { get; set; }

        [MaxLength(50)]
        public string MathersPhoneNumber { get; set; }

        [MaxLength(50)]
        public string OthersFamilyPhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime RegistrationDate { get; set; }

        [MaxLength(150)]
        public string ImageAvatarName { get; set; }
    }
}
