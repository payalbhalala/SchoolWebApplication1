using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SectionEnrollment
    {
        [Column("SectionId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Section name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string SectionName { get; set; }

        [ForeignKey(nameof(Organization))]
        public Guid OrganizationId { get; set; }

        public Organization Organization { get; set; }
    }
}
