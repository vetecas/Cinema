using CinemaDomain.Base;

namespace CinemaRepositorio.Base
{
    public interface InterfaceBaseRepository <TypeEntity> where TypeEntity : InterfaceBaseEntity
    {
        // Métodos do CRUD
        void Create(TypeEntity entity);
        TypeEntity ReadById(int id);
        IList <TypeEntity> ReadAll();
        void update(TypeEntity entity);
        void Delete(int id);
    }
}
