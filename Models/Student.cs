using System.ComponentModel.DataAnnotations;
namespace MyWebApplication.Models
{
    public enum Gender
    {
        Male, Female, Other
    }
    public class Student
    {
        [Display(Name = "Student ID")]
        public int SId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Type Your Name")]
        [MinLength(3, ErrorMessage = "Must Type 3 Char")]
        [Display(Name = "Student Name")]
        public string SName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Type Your Father Name")]
        [MinLength(3, ErrorMessage = "Must Type 3 Char")]
        [Display(Name = "Father Name")]
        public string FName { get; set; }

        public Gender Gender { get; set; }

        [StringLength(30)]
        [MinLength(11, ErrorMessage = "Must Type 11 Char")]
        [Display(Name = "Phone No")]
        public string SPhone { get; set; }

        [StringLength(30)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong Email Address")]
        [Display(Name = "Email")]
        public string SEmail { get; set; }

        [Range(5, 15, ErrorMessage = "Age must be between 5 to 15")]
        public int Age { get; set; }
        [Display(Name = "Date Of Admission")]
        public DateTime DOA { get; set; }

        [StringLength(250)]
        [Display(Name = "Student Address")]
        public string SAddress { get; set; }

    }
}
