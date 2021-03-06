using System.ComponentModel.DataAnnotations;

namespace TMSAPI.Models
{
    public class TrainerManager
    {
        [Key]
        public int TMID { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; } = "NA";

        [Required, MaxLength(15)]
        public string PhoneNumber { get; set; } = "NA";

        [Required, Range(0, 20)]
        public int Experience { get; set; } = 0;
        [Required, MaxLength(30)]
        public string EducationQualification { get; set; } = "NA";
        [Required]
        public string DOB { get; set; } = "NA";

        [Required, MaxLength(100)]
        public string Address { get; set; } = "NA";

        [Required, MaxLength(30)]
        public string Role { get; set; } = "Training Manager";

        [Required, MaxLength(30)]
        public string Position { get; set; }

        [Required, MaxLength(30)]
        public string EmailID { get; set; }

        [Required, MaxLength(15)]
        public string Password { get; set; }
    }
}
