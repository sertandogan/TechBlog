using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int IsDeleted { get; set; }

    }
}
