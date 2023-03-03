using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Servis
    {
        private List<Zaznam> zaznamy;

        public Servis()
        {
            zaznamy = new List<Zaznam>();
        }
        /// <summary>
        /// Přidání pojištěného
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="telefon"></param>
        /// <param name="vek"></param>
        public void Pridej(string jmeno, string prijmeni, string telefon, byte vek)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, telefon, vek));
        }
        /// <summary>
        /// Výpis všech pojištěných
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="telefon"></param>
        /// <param name="vek"></param>
        public void Vypis()
        {
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (Zaznam N in zaznamy)
                {
                    Console.WriteLine(N);
                }
                return;
            }
            else
                //Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }
        /// <summary>
        /// Vyhledání pojištěného
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public List<Zaznam> Vyhledej(string jmeno, string prijmeni, bool ano)
        {

            foreach (Zaznam hledany in zaznamy)

            {
                if ((hledany.jmeno == jmeno) && (hledany.prijmeni == prijmeni))

                {
                    Console.WriteLine(hledany);
                }
            }
            return zaznamy;


        }




    }
}