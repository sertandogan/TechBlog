using Domain.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Category : BaseEntity
    {
        public Category()
        {
            CategoryPost = new HashSet<CategoryPost>();
        }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<CategoryPost> CategoryPost { get; set; }
    }
}
