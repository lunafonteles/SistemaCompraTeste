using MediatR;
using SistemaCompra.Domain.Core.Model;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System.Collections.Generic;
using System;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra {
    public class RegistrarCompraCommand : IRequest<bool> {
        public string UsuarioSolicitante { get; set; }
        public string NomeFornecedor { get; set; }
        public List<Item> Itens { get; set; }
        //public DateTime Data { get; set; }
        //public Money TotalGeral { get; set; }
        //public Situacao Situacao { get; private set; }
    }
}
