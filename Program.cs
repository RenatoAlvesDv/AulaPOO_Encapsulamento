using System;
using AulaPOO_Encapsulamento.Classe;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           MasterCard m = new MasterCard();
           
           m.Parcelas = 12;
        

           Console.WriteLine(m.Parcelas);
        }
    }

    
}
