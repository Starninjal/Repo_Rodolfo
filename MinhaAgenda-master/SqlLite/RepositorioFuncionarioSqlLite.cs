using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;
using MinhaAgenda.Plugins.SqlLite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite
{
    public class RepositorioFuncionarioSqlLite : IRepositorioDeFuncionarios 
    {
        private SQLiteAsyncConnection _database;

        public RepositorioFuncionarioSqlLite()
        {
            _database = new SQLiteAsyncConnection(Constantes._databasepath);
            _database.CreateTableAsync<Funcionario>().Wait();
        }

        public Task AdicionarFuncionario(Funcionario funcionario)
        {
            return Task.FromResult(AdicionarFuncionarioAsync(funcionario));
        }

        public async Task AdicionarFuncionarioAsync(Funcionario funcionario)
        {
            await _database.InsertAsync(funcionario);
        }
    }
}
