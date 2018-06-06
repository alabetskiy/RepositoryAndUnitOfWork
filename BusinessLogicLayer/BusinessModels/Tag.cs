using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogicLayer.BusinessModels
{
    public class Tag
    {
        public Tag()
        {
            Posts = new HashSet<PostTag>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<PostTag> Posts { get; set; }
    }
}
