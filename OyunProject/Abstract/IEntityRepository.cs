using OyunProject.Abstract.Imzalama;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProject.Abstract
{
    public interface IEntityRepository<T>where T:class,IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
