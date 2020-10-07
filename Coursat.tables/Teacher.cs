using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Coursat.tables
{
   public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public String FullName { get; set; }
        public string subject { get; set; }
        public virtual EducationalLevel EducationalLevel { get; set; }
        [ForeignKey("EducationalLevel")]
        public int EducationalLevelId { get; set; }

        
    }
}
