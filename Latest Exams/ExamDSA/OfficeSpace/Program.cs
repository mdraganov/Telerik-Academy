using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSpace
{
    class Program
    {
        static List<Task> tasks;
        static int numberOfTasks;
        static int[] times;
        static bool hasCycle;

        static void MockInput()
        {
            var input = @"3
4 8 16
3
1
2";
            Console.SetIn(new StringReader(input));
        }

        static void Main()
        {
            //MockInput();
            hasCycle = false;
            numberOfTasks = int.Parse(Console.ReadLine());
            times = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();

            tasks = new List<Task>();

            for (int i = 0; i < numberOfTasks; i++)
            {
                var newTask = new Task(i);
                tasks.Add(newTask);
            }

            for (int i = 0; i < numberOfTasks; i++)
            {
                var dependencyIds = Console.ReadLine().Split().Select(t => int.Parse(t) - 1).ToArray();

                if (dependencyIds[0] > -1)
                {
                    foreach (var depId in dependencyIds)
                    {
                        tasks[i].Dependencies.Add(tasks[depId]);
                    }
                }
                else
                {
                    tasks[i].Time = times[i];
                }
            }

            //var SortedNodes = new List<Node>();
            //var nodeWithoutOutgoingEdges = tasks.FirstOrDefault(n => n.Visited == false && (n.Dependencies.Count == 0 || n.Dependencies.All(node => node.Visited)));

            //while (nodeWithoutOutgoingEdges != null)
            //{
            //    nodeWithoutOutgoingEdges.Visited = true;
            //    SortedNodes.Add(nodeWithoutOutgoingEdges);

            //    nodeWithoutOutgoingEdges = tasks.FirstOrDefault(n => n.Visited == false && (n.Dependencies.Count == 0 || n.Dependencies.All(node => node.Visited)));
            //}

            foreach (var task in tasks)
            {
                CalculateTime(task.Id, task.Id);
            }

            if (!hasCycle)
            {
                Console.WriteLine(tasks.Max(t => t.Time));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        public static void CalculateTime(int taskId, int cycleCheckId)
        {
            if (tasks[taskId].Time != 0)
            {
                return;
            }

            tasks[taskId].Time += times[taskId];

            foreach (var task in tasks[taskId].Dependencies)
            {
                if (task.Dependencies.Any(d => d.Id == cycleCheckId))
                {
                    hasCycle = true;
                }
                CalculateTime(task.Id, cycleCheckId);
            }

            var maxTime = tasks[taskId].Dependencies.Max(d => d.Time);
            tasks[taskId].Time += maxTime;
        }
    }

    public class Task
    {
        public Task(int id)
        {
            this.Id = id;
            this.Dependencies = new List<Task>();
            this.Time = 0;
        }

        public int Id { get; private set; }

        public int Time { get; set; }

        public bool Visited { get; set; }

        public List<Task> Dependencies { get; set; }
    }
}
