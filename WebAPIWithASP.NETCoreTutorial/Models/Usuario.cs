using System;
using System.Collections.Generic;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;
}
