using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract.Entities;

namespace OyunProject.Abstract
{
    public interface IEntityRepository<T>where T:class,IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
