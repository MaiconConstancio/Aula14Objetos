using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Endereco
    {
        private string rua;
        private string bairro;
        private string cidade;

        public Endereco(string rua, string bairro, string cidade)
        {
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public void mostra()
        {
            Console.WriteLine($"Você mora na rua, {rua} localizado no bairro, {bairro} na cidade de {cidade}.");
        }

    }
}
