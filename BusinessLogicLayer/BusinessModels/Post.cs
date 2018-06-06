using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.BusinessModels
{
    public class Post
    {
        public Post()
        {
            Tags = new List<PostTag>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public virtual User User { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<PostTag> Tags { get; set; }

        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }
    }
}
