using System;
using System.Collections.Generic;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;

public partial class Comentario
{
    public int ComentarioId { get; set; }

    public string Texto { get; set; } = null!;

    public DateTime? DataComentario { get; set; }

    public int? ProdutoId { get; set; }

    public virtual Produto? Produto { get; set; }
}
