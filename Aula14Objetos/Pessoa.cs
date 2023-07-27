using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Pessoa
    {
        //atributos
        private string nome;
        private int idade;
        private bool inadimplente = false;
        public Endereco endereco;

        //================================== O construtor ========================================================

        public Pessoa(string nome, int idade, string rua, string bairro, string cidade) //Ele se chama o mesmo que o //internal class Pessoa// quando cria, ele chama sozinho os atributos (string e int...)
            //tudo que tiver dentro do parenteses, é oque ele vai pedir, para criar as coisas tipo "string nome", a pessoa tem que passar o nome
            //E toda vez que der um new, você perde os nomes que foram preenchos, então para jogar nos atributos acima, precisa usar o [this.nome = nome]
            //se não coloca [this] você esta se referindo ao [nome] do "public Pessoa(string nome)"
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = new Endereco(rua, bairro, cidade);
            
        }

        //========================================================================================================

        //Métodos

        public void mostra()
        {
            Console.WriteLine($"Eu sou o {nome} tenho {idade} anos");
        }



    }
}
