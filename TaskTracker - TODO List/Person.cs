using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker___TODO_List;

namespace TaskTracker___TODO_List
{
    public class Person
    {
        private string Name;
        private List<Task> tasks = new List<Task>();
        private int NumberOfTasks;

        public Person(string name) 
        {
            this.Name = name;
            NumberOfTasks = 0;
        }

        public void AddTask(Task task) 
        {
            tasks.Add(task);
            task.SetName(task.GetName());
            NumberOfTasks++;
        }
        public void RemoveTask(int index) 
        {
            tasks.Remove(tasks[index - 1]);
            NumberOfTasks--;
        }

        public void MarkTask(int index) 
        {
            tasks[index - 1].MarkUp();
        }

        public void PrintList()
        {
            foreach (Task task in tasks) 
            {             
                Console.WriteLine(task.Print());
            }
        }     
    }
}
