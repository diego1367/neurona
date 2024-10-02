namespace Businnes
{
    using Businnes.Interfaces;
    using Entities;
    using Repository;
    public class TransferenciaBusiness : ITransferenciaBusiness
    {
        private IUnitOfWork _unit;
        public TransferenciaBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public bool Insert(Transferencia ciudad)
        {
            try
            {
                this._unit.GenericRepository<Transferencia>().Insert(ciudad);
                this._unit.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Transferencia>  GetAll()
        {
            try
            {
                return this._unit.GenericRepository<Transferencia>().Get().ToList();
            }
            catch (Exception ex)
            {
                return new List<Transferencia>();
            }
        }
    }
}
