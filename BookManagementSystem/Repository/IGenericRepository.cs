﻿using BookManagementSystem.Data;

namespace BookManagementSystem.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        /*        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        */
        void Add(T entity);
       
        void Remove(int id);
       
    }

}
