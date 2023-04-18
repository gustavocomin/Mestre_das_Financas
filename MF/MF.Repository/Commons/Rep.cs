﻿using MF.Domain.Commons;
using MF.Domain.Commons.ClassesBase;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Commons
{
    public class Rep<T> : IRep<T>
    {
        private readonly Contexto _contexto;

        public Rep(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<T> FindAll<T>() where T : class
        {
            return _contexto.Set<T>().ToList();
        }

        public T FindById<T>(int id) where T : IdBase
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges<T>(T entity) where T : class
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public void DeleteById<T>(int id) where T : class
        {
            var entity = _contexto.Set<T>().Find(id);
            if (entity != null)
            {
                _contexto.Set<T>().Remove(entity);
                _contexto.SaveChanges();
            }
        }

        public void DeleteByIds<T>(List<int> ids) where T : IdBase
        {
            var entities = _contexto.Set<T>().Where(x => ids.Contains(x.Id)).ToList();
            if (entities.Count > 0)
            {
                _contexto.Set<T>().RemoveRange(entities);
                _contexto.SaveChanges();
            }
        }
    }
}