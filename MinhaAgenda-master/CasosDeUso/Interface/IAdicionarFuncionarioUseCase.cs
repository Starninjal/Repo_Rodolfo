using CoreBusiness.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CasosDeUso.Interface
{
    public interface IAdicionarFuncionarioUseCase
    {
        Task ExecutaAsync(Funcionario funcionario);
    }
}
