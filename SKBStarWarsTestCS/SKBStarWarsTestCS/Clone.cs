using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SKBStarWarsTestCS
{
    class Clone
    {
        private ArrayList learnPrograms = new ArrayList();
        private ArrayList history = new ArrayList();
        private String lastDeletedProgram;
        public int cloneId;

        public Clone(int cloneId)
        {
            this.cloneId = cloneId;
            learnPrograms.Add("basic");
        }
         
        public void AddProgram(ICommand command, String program)
        {
            learnPrograms.Add(program);
            history.Add(command);
        }

        public void AddCommand(ICommand command)
        {
            history.Add(command);
        }

        public String GetLastProgram()
        {
            return learnPrograms[learnPrograms.Count - 1].ToString();
        }

        public void RemoveLastProgram()
        {
            if (learnPrograms[learnPrograms.Count - 1].ToString().Equals("basic"))
            {
                Console.WriteLine("Error: Clone is basic");
                return;
            }
            lastDeletedProgram = learnPrograms[learnPrograms.Count - 1].ToString();
            learnPrograms.RemoveAt(learnPrograms.Count - 1);
            history.Add(new CommandRollback());
        }

        public ArrayList GetHistory()
        {
            return history;
        }

        public String GetLastDeletedProgram()
        {
            return lastDeletedProgram;
        }

        public ArrayList GetPrograms()
        {
            return learnPrograms;
        }
    }
}
