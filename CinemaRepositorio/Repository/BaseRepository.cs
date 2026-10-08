using CinemaDomain.Base;
using CinemaRepositorio.Base;
using CinemaRepositorio.Contest;
using Microsoft.EntityFrameworkCore;

namespace CinemaRepositorio.Repository
{
    public class BaseRepository<TypeEntity> : InterfaceBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDBContest;

        public BaseRepository(MyDBContext myDBContest)
        {
            _myDBContest = myDBContest;
        }

        public void Create(TypeEntity entity)
        {
            _myDBContest.Add(entity);
            _myDBContest.SaveChanges;
        }

        public void Delete(int id)
        {
            _myDBContest.Remove(ReadById(id));
            _myDBContest.SaveChanges;
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDBContest.Set<TypeEntity>().AsQueryable();
            var retorno = _myDBContest.ToList.Find(x => x.Id == id);

        }

        public TypeEntity ReadById(int id)
        {
            var dbContext = _myDBContest.Set<TypeEntity>().AsQueryable();
            var retorno = _myDBContest.ToList.Find(x=> x.Id == id);
        }

        public void update(TypeEntity entity)
        {
            _myDBContest.Entry(entity).State = EntityState.Modified;
            _myDBContest.SaveChanges();
        }
    }
}
