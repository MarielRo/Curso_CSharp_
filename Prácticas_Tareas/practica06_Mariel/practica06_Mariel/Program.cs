using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica06_Mariel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de Variables
            int provincia;

            Console.WriteLine("¿Indique el número de la provincia de Costa Rica donde vive?");//preguntar
            Console.WriteLine(" 1.San José. \n 2.Alajuela \n 3.Heredia \n 4.Cartago \n 5.Guanacaste \n 6.Puntarenas \n 7.Limón ");
            provincia = Int32.Parse(Console.ReadLine());

            switch (provincia){
               case 1:
                  Console.WriteLine("San José:  La ciudad cuenta con varios lugares de interés turístico, como el Teatro Nacional," +
                      " que es un importante símbolo cultural de Costa Rica. Otros puntos destacados incluyen el Museo del Oro Precolombino," +
                      " el Museo Nacional de Costa Rica, el Mercado Central y el Parque Metropolitano La Sabana.");
                   break;
                case 2:
                  Console.WriteLine("Alajuela: Volcán Poás: El Parque Nacional Volcán Poás alberga uno de los volcanes más activos" +
                      " de Costa Rica.Los visitantes pueden admirar su impresionante cráter principal y disfrutar de las hermosas vistas" +
                      " panorámicas desde su mirador.");
                  break;
                case 3:
                  Console.WriteLine("Heredia: Parque Nacional Braulio Carrillo: Gran parte del Parque Nacional Braulio Carrillo " +
                      "se encuentra en la provincia de Heredia. Este parque es una importante área protegida de Costa Rica y ofrece " +
                      "una gran variedad de ecosistemas, así como rutas de senderismo y cascadas.");
                   break;
                case 7:
                  Console.WriteLine("Limón: Parque Nacional Tortuguero: Uno de los principales atractivos de Limón es el" +
                        " Parque Nacional Tortuguero. Es un importante sitio de anidación de tortugas marinas, " +
                        "como las tortugas verdes y las tortugas baulas. Además, el parque alberga una gran variedad de flora y" +
                        " fauna, canales navegables y hermosas playas.");
                   break;
                case 4:
                    Console.WriteLine("Cartago:Volcán Irazú: La provincia de Cartago es hogar del Volcán Irazú," +
                        " uno de los volcanes más visitados de Costa Rica. Los visitantes pueden disfrutar de" +
                        " impresionantes vistas desde su cráter y apreciar los paisajes circundantes.");
                    break;
                case 5:
                    Console.WriteLine("Guanacaste: Playas: La provincia de Guanacaste es famosa por sus hermosas playas," +
                        " como Tamarindo, Playa Flamingo, Playa Conchal y Playa Hermosa. " +
                        "Estas playas son ideales para actividades acuáticas, como surf, buceo y pesca deportiva.");
                    break;
                case 6:
                    Console.WriteLine("Puntarenas: Parque Nacional Manuel Antonio: Este parque nacional es uno de los destinos" +
                        " más populares de Costa Rica. Ofrece una impresionante biodiversidad, hermosas playas, senderos" +
                        " naturales y la oportunidad de observar la vida silvestre, como monos, perezosos y aves exóticas.");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
