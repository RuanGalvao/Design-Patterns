using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class RestauranteFacade
    {
        private IPizza _fornecedorPizza;
        private IPao _fornecedorPao;

        public RestauranteFacade()
        {
            _fornecedorPizza = new FornecedorPizza();
            _fornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzaNormal()
        {
            _fornecedorPizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _fornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoAlho()
        {
            _fornecedorPao.BuscarPaoAlho();
        }

        public void BuscarPaoAlhoQueijo()
        {
            _fornecedorPao.BuscarPaoAlhoQueijo();
        }
    }
}
