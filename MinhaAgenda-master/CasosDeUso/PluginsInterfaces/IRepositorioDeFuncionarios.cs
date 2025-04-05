using System;
using CoreBusiness.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosDeUso.PluginsInterfaces
{
    public interface IRepositorioDeFuncionarios
    {
        Task AdicionarFuncionario(Funcionario funcionario);
    }
}
