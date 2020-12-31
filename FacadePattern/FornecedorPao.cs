using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoAlho()
        {
            Console.WriteLine("Obtendo Pão De Alho.");
        }

        public void BuscarPaoAlhoQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo Pão De Alho com Queijo.");
        }

        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo Queijo.");
        }
    }
}
