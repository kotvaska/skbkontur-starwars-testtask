using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SKBStarWarsTestCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clone> clones = new List<Clone>();
            List<Command> commands = new List<Command>();

            Random rnd = new Random();

            int queries = rnd.Next(1, 50);
            while (queries == 0)
            {
                queries = rnd.Next(1, 50);
            }
            int programsCount = rnd.Next(0, 500000);

            Console.WriteLine("Queris: {0}, Programs: {1}", queries, programsCount);

            for (int i = 0; i < queries; ++i)
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        commands.Add(new CommandLearn(rnd.Next(1, programsCount).ToString()));
                        break;
                    case 1:
                        commands.Add(new CommandRelearn());
                        break;
                    case 2:
                        commands.Add(new CommandCheck());
                        break;
                    case 3:
                        commands.Add(new CommandClone());
                        break;
                    case 4:
                        commands.Add(new CommandRollback());
                        break;
                }

            }

            clones.Add(new Clone(1));
            clones.Add(new Clone(2));

            for (int i = 0; i < queries; ++i)
            {
                for (int j = 0; j < clones.Count; ++j)
                {
                    commands.ElementAt(i).execute(clones.ElementAt(j));
                }
            }

            Console.ReadLine();
        }
    }
}
