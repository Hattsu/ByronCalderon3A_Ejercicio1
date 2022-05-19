using System;

namespace ByronCalderon3A_Ej1
{
    public class Num_mayor
    {
        //Variables
        private double numero1
        {
            set;get;
        }
        private double numero2 {
            set;get;
        }
        //Constructor.
        public Num_mayor(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }
        //Resolver problema planteado mediante un "if".
        public void Elegir_num()
        {
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1+" es número mayor de los dos ingresados -> ("+numero1+", "+numero2+")");
            }
            else{
                Console.WriteLine(numero2+" es número mayor de los dos ingresados -> ("+numero1+", "+numero2+")");
            }
        }
    }
}