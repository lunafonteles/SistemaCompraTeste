using MediatR;
using Microsoft.AspNetCore.Mvc;
//using SistemaCompra.Application.SolicitacaoCompra.Command.AtualizarEndereco//;
using SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra;
//using SistemaCompra.Application.SolicitacaoCompra.Query.ObterCompra;

namespace SistemaCompra.API.SolicitacaoCompra {
    public class SolicitacaoCompraController : ControllerBase {

        private readonly IMediator _mediator;

        public SolicitacaoCompraController(IMediator mediator) {
            this._mediator = mediator;
        }

        //[HttpGet, Route("compra/{id}")]
        //public IActionResult Obter(Guid id) {
        //    var query = new ObterCompra() { Id = id };
        //    var compraViewModel = _mediator.Send(query);
        //    return Ok(compraViewModel);
        //}

        [HttpPost, Route("compra/registro")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult RegistrarCompra([FromBody] RegistrarCompraCommand registrarCompraCommand) {
            _mediator.Send(registrarCompraCommand);
            return StatusCode(201);
        }

        //[HttpPut, Route("compra/atualiza-endereco")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(500)]
        //public IActionResult AtualizarPreco([FromBody] AtualizarPrecoCommand atualizarPrecoCommand) {
        //    _mediator.Send(atualizarPrecoCommand);
        //    return Ok();

        //}
        
    }
}
