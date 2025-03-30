using System;
//int num1;
//int num2;
//const double PI = Math.PI;
//Console.WriteLine("Escribe un numero");
//num1 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Escribe el segundo numero");
//num2 = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine($"La suma es: {num1 + num2} y pi es: {PI}");
//Console.WriteLine("cw es el atajo para la linea de texto {0}", num1 + num2);

namespace MathProblem
{
    class Areas
    {
        int menu = 0;
        static void Main()
        {
            var areas = new Areas();
            int opc = 0;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Desea calcular el area de: ");
            Console.WriteLine("1. Circulo \n2. Cuadrado");
            Console.WriteLine("----------------------------");
            opc = Convert.ToInt16(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    areas.AreaCirculo();
                    break;
                case 2:
                    areas.AreaCuadrado();
                    break;
            }
        }

       public void AreaCirculo()
        {
            const double PI = Math.PI;
            Console.WriteLine("Por favor introduzca el diametro del circulo.");
            double diametro = double.Parse(Console.ReadLine());
            double perimetro = diametro * PI;
            Console.WriteLine($"El perimetro es: {perimetro:N4}");
            double area = (diametro / 2) * (diametro / 2) * PI;
            Console.WriteLine($"Su area es: {area:N4}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("¿Desea realizar otro calculo?");
            Console.WriteLine("(1)Si por favor. \n(2)No, terminar.");
            Console.WriteLine("----------------------------");
            menu = Convert.ToInt16(Console.ReadLine());
            if (menu == 1)
            {
                Main();
            }
            if (menu == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Usted no seleccionó una opción valida.");
            }
        }

        public void AreaCuadrado()
        {
            int[] array = new int[4];
            int num1, area;
            int perimetro = 0;
            
            Console.WriteLine("Por favor escriba uno de los lados del cuadrado.");
            num1 = int.Parse(Console.ReadLine());
            area = Convert.ToInt32( Math.Pow(num1, 2));
            Console.WriteLine($"El Area es: {area}");

            foreach (int i in array)
            {
                perimetro = array[i] += num1;
                
            }
            Console.WriteLine($"El hpta perimetro es: {perimetro}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("¿Desea realizar otro calculo?");
            Console.WriteLine("(1)Si por favor. \n(2)No, terminar.");
            Console.WriteLine("----------------------------");
            menu = Convert.ToInt16(Console.ReadLine());
            if (menu == 1)
            {
                Main();
            }
            if (menu == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Usted no seleccionó una opción valida.");
            }
        }
    }
}