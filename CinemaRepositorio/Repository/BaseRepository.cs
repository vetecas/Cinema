using CinemaDomain.Base;
using CinemaRepositorio.Base;
using CinemaRepositorio.Context;
using Microsoft.EntityFrameworkCore;

namespace CinemaRepositorio.Repository
{
    public class BaseRepository<TypeEntity> : InterfaceBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDBContext;

        public BaseRepository(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }

        public void Create(TypeEntity entity)
        {
            _myDBContext.Add(entity);
            _myDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = ReadById(id);
            if (entity == null) return;
            _myDBContext.Remove(entity);
            _myDBContext.SaveChanges();
        }

        public IList<TypeEntity> ReadAll()
        {
            return _myDBContext.Set<TypeEntity>().ToList();
        }

        public TypeEntity ReadById(int id)
        {
            return _myDBContext.Set<TypeEntity>().Find(id);
        }

        public void update(TypeEntity entity)
        {
            _myDBContext.Entry(entity).State = EntityState.Modified;
            _myDBContext.SaveChanges();
        }
    }
}
