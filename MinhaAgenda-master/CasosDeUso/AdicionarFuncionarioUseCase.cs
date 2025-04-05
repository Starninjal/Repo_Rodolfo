using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CasosDeUso
{
    public class AdicionarFuncionarioUseCase : IAdicionarFuncionarioUseCase
    {
        private readonly IRepositorioDeFuncionarios _funcionarioRepository;

        public AdicionarFuncionarioUseCase(IRepositorioDeFuncionarios funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task ExecutaAsync(Funcionario funcionario)
        {
            await _funcionarioRepository.AdicionarFuncionario(funcionario);
        }
    }
}
