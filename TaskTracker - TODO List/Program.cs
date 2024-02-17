using TaskTracker___TODO_List;
using Task = TaskTracker___TODO_List.Task;

class TODO_LIST
    {
        static void Main() 
        {
            Console.WriteLine("============= Welcome To TODO LIST APP =============");
            var person = new Person("Ahmed");
            bool ON_OFF = true;
            while (ON_OFF)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("=============== YOUR LIST CONTAINS ===============");
                person.PrintList();
                Console.WriteLine("=================================");
                Console.WriteLine("(1): Add New Task\n(2): Remove Task\n(3): Mark Task \n(4): To Exit our program ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if ( choice == 1)
                {
                    Console.WriteLine("Enter Task Name: ");
                    string name = Console.ReadLine();
                    var task1 = new Task(name);
                    person.AddTask(task1);
                }
                else if ( choice == 2 )
                {
                    Console.WriteLine("Which Task Do You Want To Remove: ");
                    int index = Convert.ToInt32( Console.ReadLine());
                    person.RemoveTask(index);
                }
                else if ( choice == 3 )
                {
                    Console.WriteLine("Which Task Do You Want To MarkUp: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    person.MarkTask(index);
                }
                else if ( choice == 4)
                {
                    ON_OFF = false;
                }
            }
        }
    }