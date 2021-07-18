using System;
using System.Linq;
using System.Threading.Tasks;

namespace LearnLINQ
{
    class GroupJoinDemo
    {
        static void Main()
        {
            Worker[] workers =
            {
                new Worker(1,"Rostyslav",20.65),
                new Worker(2, "Anastasiya",19.45),
                new Worker(3, "Maksimus", 17.32)
            };

            WorkerTask[] workerTasks =
            {
                new WorkerTask(2,"Create designer of site"),
                new WorkerTask(1,"Create application"),
                new WorkerTask(3,"Create system of Tesla")
            };
            
            var joinQuery = from worker in workers
                join oneTask in workerTasks
                    on worker.Id equals oneTask.Id
                select new {worker.Name, oneTask.Description};
            foreach (var t in joinQuery)
            {
                Console.WriteLine("{0}\t{1}",t.Name,t.Description);
            }
        }
    }
}
