namespace Businnes.Interfaces
{
    using Entities;

    public interface ITransferenciaBusiness
    {
        bool Insert(Transferencia ciudad);
        List<Transferencia>  GetAll();

    }
}
