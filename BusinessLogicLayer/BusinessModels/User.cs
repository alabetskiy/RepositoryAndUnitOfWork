using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.BusinessModels
{
    public class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
