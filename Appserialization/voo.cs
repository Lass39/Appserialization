using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appserialization
{
    [Serializable]
    public class Voo
    {
        public Voo()
        {
            
        }

        public Voo(string codigo, string origem, string destino, string horario, string compania, string operando)
        {
            Codigo = codigo;
            Origem = origem;
            Destino = destino;
            Horario = horario;
            Compania = compania;
            Operando = operando;
        }

        public string Codigo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Horario { get; set; }
        public string Compania { get; set; }
        public string Operando { get; set; }
    }
}
