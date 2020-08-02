using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Post: BaseEntity
    {
        public Post()
        {
            CategoryPost = new HashSet<CategoryPost>();
            PostTag = new HashSet<PostTag>();
        }

        [Required]
        public string Content { get; set; }
        [Required]
        public string Title { get; set; }

        public virtual ICollection<CategoryPost> CategoryPost { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }

    }
}
