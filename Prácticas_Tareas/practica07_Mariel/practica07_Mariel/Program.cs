using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica07_Mariel
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //declaración de variables 
                int numeroMes;

                Console.WriteLine("Ingrese un número entre 1 y 12:");
                numeroMes = Int32.Parse(Console.ReadLine());
  
                switch (numeroMes)
                {
                    case 1:
                        Console.WriteLine(" Mes en Español: Enero. \n Mes en Inglés: January. \n Mes en Francés: Janvier " +
                            "\n Mes en Portugués: Janeiro \n Mes en Alemán: Januar  ");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine(" Mes en Español: Febrero. \n Mes en Inglés: February. \n Mes en Francés: Février " +
                            "\n Mes en Portugués: Fevereiro \n Mes en Alemán: Februar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(" Mes en Español: Marzo. \n Mes en Inglés: March. \n Mes en Francés: Mars " +
                            "\n Mes en Portugués: Marco \n Mes en Alemán: März ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(" Mes en Español: Abril. \n Mes en Inglés: April. \n Mes en Francés: Avril " +
                            "\n Mes en Portugués: Abril \n Mes en Alemán: April  ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(" Mes en Español: Mayo. \n Mes en Inglés: May. \n Mes en Francés: Mai " +
                            "\n Mes en Portugués: Maio \n Mes en Alemán: Mai  ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine(" Mes en Español: Junio. \n Mes en Inglés: June. \n Mes en Francés: Juin " +
                            "\n Mes en Portugués: Junho \n Mes en Alemán: Juni  ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine(" Mes en Español: Julio. \n Mes en Inglés: July. \n Mes en Francés: Juillet " +
                            "\n Mes en Portugués: Julho \n Mes en Alemán: Juli  ");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine(" Mes en Español: Agosto. \n Mes en Inglés: August. \n Mes en Francés: Août " +
                             "\n Mes en Portugués: Agosto \n Mes en Alemán: August  ");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine(" Mes en Español: Septiembre. \n Mes en Inglés: September. \n Mes en Francés: Septembre " +
                             "\n Mes en Portugués: Setembro  \n Mes en Alemán: September  ");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.WriteLine(" Mes en Español: Octubre. \n Mes en Inglés: October. \n Mes en Francés: Octobre " +
                            "\n Mes en Portugués: Outubro \n Mes en Alemán: Oktober  ");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.WriteLine(" Mes en Español: Noviembre. \n Mes en Inglés: November. \n Mes en Francés: Novembre " +
                             "\n Mes en Portugués: Novembro \n Mes en Alemán: November  ");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.WriteLine(" Mes en Español: Diciembre. \n Mes en Inglés: December. \n Mes en Francés: Décembre " +
                             "\n Mes en Portugués: Dezembro \n Mes en Alemán: Dezember ");
                        Console.ReadKey();
                        break;
                    default:
                    Console.WriteLine("Opción no válida");
                    Console.ReadKey();
                    break;
                }
            }

        }
    }

}

