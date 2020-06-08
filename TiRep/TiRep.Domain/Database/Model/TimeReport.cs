using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiRep.Domain.Database.Model
{
    public class TimeReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string RecordId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public TimeSpan Deduction { get; set; }

        [Required]
        public TimeSpan Balance { get; set; }

        [Required]
        public TimeSpan FinalBalance { get; set; }
    }
}