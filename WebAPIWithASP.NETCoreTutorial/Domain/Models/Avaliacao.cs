using System;
using System.Collections.Generic;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;

public partial class Avaliacao
{
    public int AvaliacaoId { get; set; }

    public int Pontuacao { get; set; }

    public string? Comentario { get; set; }

    public DateTime? DataAvaliacao { get; set; }

    public int? ProdutoId { get; set; }

    public virtual Produto? Produto { get; set; }
}
