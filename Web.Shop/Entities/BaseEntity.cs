using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Entities
{

    public interface IBaseEntity<T>
    {
        T Id { get; set; }
        DateTime ? DateDelete { get; set; }
    }

    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
        public virtual DateTime DateCreate { get; set; }
        public virtual DateTime ? DateModify { get; set; }
        public virtual DateTime ? DateDelete { get; set; }
    }
}
