namespace Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Transferencia
    {
        [Key]
        public int IdTransferencia { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
    }
}
