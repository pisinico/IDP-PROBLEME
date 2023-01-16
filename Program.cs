using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_cu_clasa_student_2
{
    /*Sa se creeze un proiect de tip consolã.Sã se implementeze urmãtoarele cerinte:
    a.Sã se adauge in Solution Explorer o clasã numita Student caracterizata de proprietatea: id (int) si prenume (string);

    b.Sa se creeze in programul principal o list cu elemente de tip Student si sã se afiseze elementele din aceasta list.
    Valorile corespunzatoare prenumelui vor fi citite dintr-un fisier text, iar id-ul reprezintà pozitia prenumelui din fisier.
    Afisarea datelor se va face din list, iar in caz contrar, nu se va puncta cerinta;
    
    c.Sa se adauge în fisier prenumele unui nou student.Valoarea prenumelui se citeste de la tastatura;
    d.Sa se modifice prenumele unui student din fisier.Noua valoarea va fi cititã de la tastaturã Studentul pentru care se realizeazã modificarea este identificat prin intermediul id-ului, citit de la tastatura.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //b
            List<Student> students = new List<Student>();
            string[] linii = File.ReadAllLines(@"D:\10213bashar\ idStudent.txt");
            for(int i = 0; i < linii.Length; i++)
            {
                students.Add(new Student { Id = i, Prenume = linii[i] });
            }

            foreach(Student student in students)
            {
                Console.WriteLine("Id: " + student.Id + "Prenume :" + student.Prenume);
            }
            Console.ReadKey();

            //c
            Console.WriteLine("Introduceti preNumele studentului nou : ");
            string PrenumeNou = Console.ReadLine();
            File.AppendAllText("prenume.txt", PrenumeNou + Environment.NewLine);

            //d
            Console.WriteLine("Introduceti id-ul studentului : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numele studentului : ");
            string newPrenume = Console.ReadLine();

            string[] valoareaPren = File.ReadAllLines(@"\D:\10213bashar\ idStudent.txt");

            valoareaPren[id] = newPrenume;

            File.WriteAllLines("prenume.txt", valoareaPren);


        }
    }
}
