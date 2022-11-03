using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appserialization
{
    // Classe Departamento     
    [Serializable]   //indicação para a classe poder ser serializada     
    public class Departamento
    {
        private int codigo;
        private string nome;
        private string sigla;
        //Construtor default         
        public Departamento()
        {
        }

        public Departamento(int codigo, string nome, string sigla)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sigla = sigla;
        }
        public int Codigo         
        {             
            get { return codigo; }             
            set { codigo = value; }      
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        
    }
}