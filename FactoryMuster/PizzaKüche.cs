using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMuster
{
    class PizzaKüche
    {
        public Pizza erzeugePizza(string PizzaSorte)
        {
            if (PizzaSorte.Equals("Margherita")) //PizzaSorte=="Margherita"
            {
                return new Margherita();
            }
            else if (PizzaSorte.Equals("QuattroStationi"))
            {
                return new QuattroStationi();
            }
            else if (PizzaSorte.Equals("Diabolo"))
            {
                return new Diabolo();
            }
            else
                return null;
        }
    }
}
