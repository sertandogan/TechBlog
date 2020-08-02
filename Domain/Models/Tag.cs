using Domain.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Tag : BaseEntity
    {
        public Tag()
        {
            PostTag = new HashSet<PostTag>();
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<PostTag> PostTag { get; set; }

    }
}
