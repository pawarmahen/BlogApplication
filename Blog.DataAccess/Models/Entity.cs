using System;

namespace Blog.DataAccess.Models
{
    public abstract class Entity
    {
        public Entity()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn=DateTime.Now;
            CreatedBy = "Admin";
            UpdatedBy = "Admin";
        }
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
