class Program
{

    public static void Main()
    {
        TaskScheduler<string, int> taskScheduler = new TaskScheduler<string, int>();

        string choice = "";
        bool firstTask;
        do
        {
            firstTask = taskScheduler.WelcomeTask();
            if(firstTask == false)
            {
                taskScheduler.AddTask();
            }
            else if (firstTask == true)
            {
                taskScheduler.SortTasks();
                taskScheduler.ShowAllTasks();
                choice = taskScheduler.UserChoice();
                switch(choice)
                {
                    case "done": taskScheduler.MarkTaskAsDone(); break;
                    case "create": taskScheduler.AddTask(); break;
                    case "tasks": taskScheduler.SortTasks(); break;
                    case "execute": taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing task: {task}")); break;
                    case "exit": return;
                    default: Console.WriteLine("Invalid choice input."); break;
                }
            }
        } while (choice != "exit");
    }

}