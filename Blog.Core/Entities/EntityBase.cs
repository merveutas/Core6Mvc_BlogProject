using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
    
        public EntityBase()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            DeletedBy = "";
        }

        public virtual Guid Id { get; set; } 
        public virtual string CreateBy { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;    
    }
}
