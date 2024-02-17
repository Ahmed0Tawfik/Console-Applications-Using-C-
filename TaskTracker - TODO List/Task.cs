using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker___TODO_List
{
    public class Task
    {
        private string TaskName = "";
        private bool IsCompleted;

        public Task(string name) 
        {
            TaskName = name;
            IsCompleted = false;
        }

        public string GetName()
        {
            return TaskName;
        }

        public void SetName(string name) 
        {
            TaskName = name;
        }

        public void MarkUp() 
        {
            this.IsCompleted = true;
        }

        public string Print()
        {
            if(IsCompleted)
            {
                Console.WriteLine(  "Task Name : " + TaskName + " (Completed)");
            }
            else
            {
                Console.WriteLine("Task Name : " + TaskName + " (Not Completed)");
            }
            return "";
        }
    }
}
