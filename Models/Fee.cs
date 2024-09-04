using System.ComponentModel.DataAnnotations;

namespace MyWebApplication.Models
{
    public enum FMonth
    {
        January,February,March,April,May,June,July,August,September,October,November,December
    }
    public class Fee
    {
        [Display(Name = "Fee Id")]
        public int FId { get; set; }
        [Display(Name = "Fee Month")]
        [Required(ErrorMessage = "Enter Fee Month Here!")]
        public FMonth FMonth { get; set; }
        [Display(Name = "Fee Amount")]
        [Required(ErrorMessage ="Enter Fee Amount Here!")]
        public string FAmount { get; set; }
        public int SId { get; set; }
        public Student Student { get; set; }
    }
}
