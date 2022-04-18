using System;
using System.Collections.Generic;
using System.Text;
using salario.banco;
using SQLite;
using salario;
namespace salario.banco
{
    class Banco_funcoes
    {
        private SQLiteConnection conexao;
        string pasta = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);
        public void CriarBancoDeDados()
        {
            string dbPath = System.IO.Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "funcionarios.db3");
            conexao = new SQLiteConnection(dbPath);
            conexao.CreateTable<funcionarios>();
        }
        public void InserirFuncionario(string nome, string cargo, string vh, string ht)
        {
            conexao.Query<funcionarios>("INSERT INTO funcionarios (Nome,Cargo,VH,HT) " +
                "VALUES('" + nome + "','" + cargo + "','" + vh + "'," + ht + ")");

        }
        public List<funcionarios> Getfuncionarios()
        {
            return conexao.Query<funcionarios>("SELECT * FROM funcionarios");
        }
        public void Excluirfuncionarios(string codigo)
        {
            conexao.Query<funcionarios>("DELETE FROM funcionarios WHERE Codigo = " + codigo);
        }
        public void Editarfuncionarios(string codigo, string nome, string cargo, string vh, string ht)
        {
            conexao.Query<funcionarios>("UPDATE funcionarios SET Nome = '" + nome + "',Cargo = '"
                + cargo + "',VH ='" + vh + "',HT = '" + ht + "' WHERE Codigo = '" + codigo + "' ");

        }

    }
}