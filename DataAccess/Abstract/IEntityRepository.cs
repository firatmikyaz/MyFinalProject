﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint : generic kısıt demek
    //class : referans tip olabilir demek
    //IEntity: IEntity olabilir veya IEntity imlplemente eden bir nesne olabilir.
    //new: new'lenebilir olmalı.IEntity newlenemez.interface - soyut
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Filte veredebilir vermeyedebilir.
        T Get(Expression<Func<T, bool>> filter); //Filte zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
