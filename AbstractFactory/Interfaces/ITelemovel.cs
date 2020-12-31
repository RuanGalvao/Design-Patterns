using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    //Abstract Factory
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();
    }
}
