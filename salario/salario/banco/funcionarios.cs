using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace salario.banco
{
    class funcionarios
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double VH { get; set; }
        public int HT { get; set; }
    }
}
