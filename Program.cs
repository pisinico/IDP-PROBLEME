using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie__2_model_examen
{
    internal class Program
    {

       /* Să se creeze un proiect de tip consolă.Să se implementeze următoarele cerințe:
        a.Să se adauge în Solution Explorer o clasă numită Verificare cu următoarele proprietăți: 
        nota (int), prenume (string), nume (string);
        b.Să se creeze în programul principal o listă cu elemente de tip Verificare și să se afișeze
        elementele din această listă.Atât numărul elementelor, cât și valorile, vor fi citite de la
        tastatură.Afișarea datelor se va face din listă, iar în caz contrar, nu se va puncta cerința;
        c.Să se verifice încercarea de a introduce litere pentru note și să se afișeze un mesaj de
        atenționare;
        d.Să se numere câți studenți au note cuprinse între 7 și 9.*/
        static void Main(string[] args)
        {
            List<Verificare> elemente = new List<Verificare>();
            //b
            Console.WriteLine("Introduceti numarul de elemente :");
            var numarulDeElemente = int.Parse(Console.ReadLine());

            for(int i = 0; i < numarulDeElemente; i++)
            {
                Verificare verifica = new Verificare();

                Console.WriteLine("Introduceti Nume :");
                verifica.Nume = Console.ReadLine();

                Console.WriteLine("Introduceti prenumele :");
                verifica.Prenume = Console.ReadLine();

                Console.WriteLine("Introduceti nota  :");
                string nota = Console.ReadLine();

                if (!int.TryParse(nota, out int notaInt))
                {
                    Console.WriteLine("Nota introdusa nu este un numar. Introduceti din nou.");
                    i--;
                    continue;
                }
                verifica.Nota = notaInt;

                elemente.Add(verifica);
            }
            foreach(var verifica in elemente)
            {
                Console.WriteLine("Nume: " + verifica.Nume + "Prenume :" + verifica.Prenume + "Nota :" + verifica.Nota);
            }
            //d
            var studentiCuNoteBune = elemente.Count(c => c.Nota >= 7 && c.Nota <= 9);
            Console.WriteLine("Numarul de studenti cu nota cuprinse intre 7 si 9 :" + studentiCuNoteBune);
        }


        
        
    }
}
