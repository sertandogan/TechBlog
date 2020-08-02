using Domain.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class CategoryPost : BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
