using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tareaSebastianCastro
{
    internal class Program
    {

        static void Main(string[] args)
        {


            int opc = 0;

            while (opc != 4)
            {
                Console.Clear();

                Console.WriteLine("*EJERCICIOS*");

                Console.WriteLine(" Ejercicio 1 \n Ejercicio 2 \n Ejercicio 3 \n 4.Salir");
                Console.WriteLine(" ");
                Console.Write("Seleccione el ejercicio: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        Ejercicio1();

                        break;

                    case 2:

                        Ejercicio2();

                        break;


                    case 3:

                        Ejercicio3();

                        break;

                    case 4:

                        break;


                }

            }
        }


        public static void Ejercicio1()
        {
            int cantcam;
            double preciocam, total, disc, totaldisc;

            Console.Clear();

            Console.WriteLine("Ingrese el precio por camisa: ");
            preciocam = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de camisas: ");
            cantcam = int.Parse(Console.ReadLine());

            if (cantcam < 2)
            {
                total = cantcam * preciocam;

                Console.WriteLine("El total es de " + total);

                Console.ReadKey();

            }
            else if (cantcam >= 2 && cantcam <= 5)
            {
                disc = (cantcam * preciocam) * 0.15;

                total = cantcam * preciocam;

                totaldisc = total - disc;

                Console.WriteLine("El total sin descuento es de " + total);

                Console.WriteLine("El total es de " + totaldisc);

                Console.ReadKey();

            }
            else if (cantcam > 5)
            {
                disc = (cantcam * preciocam) * 0.20;

                total = cantcam * preciocam;

                totaldisc = total - disc;

                Console.WriteLine("El total sin descuento es de " + total);

                Console.WriteLine("El total es de " + totaldisc);

                Console.ReadKey();
            }


        }

        public static void Ejercicio2()
        {

            double[] quices = new double[3];
            double[] tareas = new double[3];
            double[] examenes = new double[3];

            int op, carnet;
            string nombre;
            double PromQ, TotalQ, TotalE, PromE, PromT, TotalT, PorQ, PorE, PorT, promedio;

            PorQ = 0; PorE = 0; PorT = 0;
            TotalE = 0; TotalT = 0; TotalQ = 0;
            PromE = 0; PromT = 0; PromQ = 0;
            op = 0;
            carnet = 0;
            nombre = " ";

            while (op != 3)
            {
                Console.Clear();

                Console.WriteLine("*Opciones*");

                Console.WriteLine(" 1. Ingresar datos \n 2. Calcular Promedio \n 3. Salir");
                Console.WriteLine(" ");
                Console.Write("Seleccione una opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Console.Clear();

                        Console.WriteLine("Ingrese el carnet del estudiante");
                        carnet = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nombre del estudiante");
                        nombre = Console.ReadLine();

                        for (int i = 0; i < quices.Length; i++)
                        {
                            Console.WriteLine("Ingrese la nota del quiz " + (i + 1));
                            quices[i] = double.Parse(Console.ReadLine());

                            TotalQ = TotalQ + quices[i];

                        }

                        Console.Clear();

                        for (int i = 0; i < examenes.Length; i++)
                        {
                            Console.WriteLine("Ingrese la nota del examen " + (i + 1));
                            examenes[i] = double.Parse(Console.ReadLine());

                            TotalE = TotalE + examenes[i];

                        }

                        Console.Clear();

                        for (int i = 0; i < tareas.Length; i++)
                        {
                            Console.WriteLine("Ingrese la nota de la tarea " + (i + 1));
                            tareas[i] = double.Parse(Console.ReadLine());

                            TotalT = TotalT + tareas[i];

                        }

                        break;

                    case 2:

                        Console.Clear();

                        PromQ = TotalQ / quices.Length;

                        PorQ = PromQ * 25 / 100;

                        PromE = TotalE / examenes.Length;

                        PorE = PromE * 45 / 100;

                        PromT = TotalT / tareas.Length;

                        PorT = PromT * 30 / 100;

                        promedio = PorE + PorQ + PorT;

                        Console.WriteLine("Estudiante: " + nombre);
                        Console.WriteLine("Carnet: " + carnet + "\n ");

                        Console.WriteLine("El porcentaje de Quices fue de: " + PorQ);

                        Console.WriteLine("El porcentaje de Examenes fue de: " + PorE);

                        Console.WriteLine("El porcentaje de Tareas fue de: " + PorT);

                        Console.WriteLine("El promedio total fue de: " + promedio);

                        if (promedio > 70)
                        {
                            Console.WriteLine(" \nEl estudiante esta aprobado.");

                        }
                        else if (promedio < 70 && promedio >= 50)
                        {
                            Console.WriteLine(" \nEl estudiante esta aplazado.");
                        }
                        else if (promedio < 50)
                        {
                            Console.WriteLine(" \nEl estudiante esta reporbado.");
                        }

                        Console.ReadKey();

                        break;
                }

            }

        }
        public static void Ejercicio3()
        {
            int cantprod, precio, total;

            precio = 0;           
            total = 0;
            cantprod = 0;

            Console.Clear();

            Console.WriteLine("Ingrese la cantidad de productos que va adquirir: ");
            cantprod = int.Parse(Console.ReadLine());

            if (cantprod <= 10)
            {

                Console.Clear();

                precio = 20;
                total = cantprod * precio;

                Console.WriteLine("El precio por articulo es de " + precio);
                Console.WriteLine("El total seria de: " +  total);

                Console.ReadKey();

            }
            else if (10 < cantprod)
            {
                Console.Clear();

                precio = 15;
                total = cantprod * precio;

                Console.WriteLine("El precio por articulo es de " + precio);
                Console.WriteLine("El total seria de: " + total);

                Console.ReadKey();

            }



        }

    }
}
