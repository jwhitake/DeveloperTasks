using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevTaskApi.Models
{
    public class Project
    {
        public Project()
        {
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        [ForeignKey("Solution")]
        public int SolutionId { get; set; }
        public Solution Solution { get; set; }

    }
}
