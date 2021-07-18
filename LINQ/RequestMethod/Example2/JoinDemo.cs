using System;
using System.Linq;

namespace LearnLINQ
{
    class GrouByDemo
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
            var query = workers.Join(workerTasks, k1 => k1.Id,
                k2 => k2.Id, (k1, k2) => new {k1.Name, k2.Description});
            foreach (var t in query)
                Console.WriteLine("{0}\t{1}",t.Name,t.Description);
        }
    }
}
