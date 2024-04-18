using System;

namespace FactoryMuster
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
           {
                try
                {
                    Console.Write("\n Mit j/J Weiter !! Mit n/N Prog. ENDE !!!!  :");
                    string str = Console.ReadLine();

                    if (str == "n" || str == "N")
                    {
                        Console.WriteLine("Programm beenden !!!! Ciao Amigo !!!!");
                        break;
                    }
                    else if (str == "j" || str == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("\n Wählen Sie bitte !!!");
                        Console.WriteLine("\n Pizza Margherita         (1)");
                        Console.WriteLine("\n Pizza Quattro Stationi   (2)");
                        Console.Write("\n Pizza Diabolo            (3)  :");
                        int wahl = Convert.ToInt32(Console.ReadLine());

                        PizzaKüche meinePizzaKüche = new PizzaKüche();

                        switch (wahl)
                        {
                            case 1:
                                Pizza meinePizza1 = meinePizzaKüche.erzeugePizza("Margherita");
                                Console.WriteLine("\nMeine Pizza ist : {0}", meinePizza1.getName());
                                break;
                            case 2:
                                Pizza meinePizza2 = meinePizzaKüche.erzeugePizza("QuattroStationi");
                                Console.WriteLine("\nMeine Pizza ist : {0}", meinePizza2.getName());
                                break;
                            case 3:
                                Pizza meinePizza3 = meinePizzaKüche.erzeugePizza("Diabolo");
                                Console.WriteLine("\nMeine Pizza ist : {0}", meinePizza3.getName());
                                break;
                            default:
                                Console.WriteLine("\n Falsche Eingabe !!!");
                                break;

                        }
                    }
                    else
                        Console.WriteLine("\n Falsche Eingabe !!!! ");


                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
           }

            Console.ReadKey();
        }
    }
}
