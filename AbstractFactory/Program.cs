using AbstractFactory.ConcreteFactory;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITelemovel nokiaTelemovel = new Nokia();
            Client nokiaClient = new Client(nokiaTelemovel);

            Console.WriteLine("********** NOKIA **********");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDetalhes());

            ITelemovel samsungTelemovel = new Samsung();
            Client samsungCliente = new Client(samsungTelemovel);

            Console.WriteLine("********** SAMSUNG **********");
            Console.WriteLine(samsungCliente.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(samsungCliente.BuscarNormalPhoneModeloDetalhes());

            Console.ReadKey();
        }
    }
}
