using System;

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
            Console.WriteLine("1. Circulo \n2. Cuadrado \n3. Triangulo \n4. Rectangulo \n0. Salir");
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
                case 3:
                    areas.AreaTriangulo();
                    break;
                case 4:
                    areas.AreaRectangulo();
                    break;
                case 0:
                    Environment.Exit(0);
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
            else if (menu == 2)
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
            int[] side = new int[4];
            int num1, area;
            int perimetro = 0;
            
            Console.WriteLine("Por favor escriba uno de los lados del cuadrado.");
            num1 = int.Parse(Console.ReadLine());
            area = Convert.ToInt32( Math.Pow(num1, 2));
            Console.WriteLine($"El Area es: {area}");

            foreach (int i in side)
            {
                perimetro = side[i] += num1;
                
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
            else if (menu == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Usted no seleccionó una opción valida.");
            }
        }

        public void AreaTriangulo()
        {
            double[] num = new double[3];
            double perimetro;
            double area = 0;
            double b, a;
            Console.WriteLine("Por favor ingrese los lados del triangulo.");
            for (int i = 0; i < num.Length; i++) 
            {
                Console.WriteLine($"Ingrese el lado numero {i+1}");
                num[i] = Convert.ToInt32(Console.ReadLine());
                area += num[i];
            }
            
            Console.WriteLine("Por favor digite la base del triangulo");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite la altura del triangulo");
            a = Convert.ToDouble(Console.ReadLine());
            perimetro = (b * a) / 2;
            Console.WriteLine($"El perimetro es: {perimetro:N4}");
            Console.WriteLine($"El area de su triangulo es: {area:N4}");
            Console.WriteLine("----------------------------");

            Console.WriteLine("----------------------------");
            Console.WriteLine("¿Desea realizar otro calculo?");
            Console.WriteLine("(1)Si por favor. \n(2)No, terminar.");
            Console.WriteLine("----------------------------");
            menu = Convert.ToInt16(Console.ReadLine());
            if (menu == 1)
            {
                Main();
            }
            else if (menu == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Usted no seleccionó una opción valida.");
            }
        }

        public void AreaRectangulo()
        {
            int b, a, perimetro, area;

            Console.WriteLine("Por favor escriba la base del rectangulo");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor escriba la altura del rectangulo");
            a = Convert.ToInt32(Console.ReadLine());
            area = b * a;
            perimetro = (b * 2) + (a * 2);
            Console.WriteLine($"El perimetro es: {perimetro} \nEl area es: { area} ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("¿Desea realizar otro calculo?");
            Console.WriteLine("(1)Si por favor. \n(2)No, terminar.");
            Console.WriteLine("----------------------------");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Main();
            }
            else if (menu == 2)
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