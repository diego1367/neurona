namespace Practicas.Controllers
{
    using Businnes.Interfaces;
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [ApiController]
    [Route("api/[controller]")]
    public class TransferenciaController : ControllerBase
    {
        private readonly ITransferenciaBusiness _transferencia;
        public TransferenciaController(ITransferenciaBusiness transferencia)
        {
            _transferencia = transferencia;
        }
        [HttpPost]
        public bool Insertar(Transferencia ciudad)
        {
            return _transferencia.Insert(ciudad);
        }

        [HttpGet]
        public List<Transferencia>  Getall()
        {
            return _transferencia.GetAll();
        }
    }
}
