using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //ProdutoB1
    public class Nokia1600 : INormalPhone
    {
        string INormalPhone.BuscarDetalhesModelo()
        {
            return "Modelo: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
