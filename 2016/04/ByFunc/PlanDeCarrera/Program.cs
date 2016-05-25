using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases;
using UsesCases.Model;

namespace PlanDeCarrera
{
    class Program
    {
        static void Main(string[] args)
        {
            DefineJob defineJob = new DefineJob();
            while (true)
            {
                ShowOptions();
                string option = Console.ReadLine();
                if (option.Equals("q", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Adios");
                    break;
                }

                if (option.Equals("job", StringComparison.InvariantCultureIgnoreCase)) {
                    defineJob.Define(CaptureJob());
                    ShowAll(defineJob.GetAll());
                }
            }
        }

        private static void ShowAll(IEnumerable<Job> jobs)
        {
            int i = 1;
            foreach (var job in jobs) {
                Console.WriteLine($"#{i++} - {job}");
            }
        }

        private static Job CaptureJob()
        {
            Console.Write("Introduzca el nombre del puesto: ");
            string title = Console.ReadLine();
            var job = new Job(title);
            Console.WriteLine();

            Console.Write("Introduzca los skills, separados por coma: ");
            string allSkills = Console.ReadLine();
            Skill[] skills = allSkills.Split(',').Select(name => new Skill(name)).ToArray();

            foreach (var skill in skills)
            {
                job.AddSkill(skill);
            }

            return job;
        }

        private static void ShowOptions()
        {
            Console.WriteLine("Q - Salir");
            Console.WriteLine("Job - Definir Job");
        
        }
    }
}
