using System;
using System.Collections.Generic;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Models;

public partial class Produto
{
    public int ProdutoId { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public decimal Preco { get; set; }

    public string? Imagem { get; set; }

    public int? CategoriaId { get; set; }

    public virtual ICollection<Avaliacao> Avaliacaos { get; set; } = new List<Avaliacao>();

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
}
