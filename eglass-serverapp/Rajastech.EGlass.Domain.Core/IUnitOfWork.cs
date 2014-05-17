namespace Rajastech.EGlass.Domain.Core
{
    public interface IUnitOfWork
    {
        void Save();
        void Discard();
    }
}
