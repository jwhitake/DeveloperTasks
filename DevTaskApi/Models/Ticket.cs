using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevTaskApi.Models
{
    public class Ticket
    {
        public Ticket()
        {
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(2500)]
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public Project Project { get; set; }
        public User User { get; set; }
    }
}
