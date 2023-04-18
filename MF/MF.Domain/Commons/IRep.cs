using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons
{
    public interface IRep<T>
    {
        List<T> FindAll<T>() where T : class;
        T FindById<T>(int id) where T : IdBase;
        void SaveChanges<T>(T entity) where T : class;
        void DeleteById<T>(int id) where T : class;
        void DeleteByIds<T>(List<int> ids) where T : IdBase;
    }

}
