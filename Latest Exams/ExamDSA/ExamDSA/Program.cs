using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDSA
{
    class Program
    {
        static void MockInput()
        {
            var input = @"add TheMightyThor God 100
add Artanis Protoss 250
add Fenix Protoss 200
add Spiderman MutatedHuman 180
add XelNaga God 500
add Wolverine MutatedHuman 200
add Zeratul Protoss 300
add Spiderman MutatedHuman 180
power 3
find Protoss
find God
remove Kerrigan
remove XelNaga
power 3
find Kerrigan
find God
end
";
            Console.SetIn(new StringReader(input));
        }

        static void Main()
        {
            MockInput();

            var units = new Dictionary<string, Unit>();
            var unitsByAttack = new SortedSet<Unit>();

            var input = Console.ReadLine();
            var finalResult = new StringBuilder();

            while (input != "end")
            {
                var currentLine = input.Split();

                if (currentLine[0] == "add")
                {
                    try
                    {
                        var newUnit = new Unit
                        {
                            Name = currentLine[1],
                            Type = currentLine[2],
                            Attack = int.Parse(currentLine[3])
                        };

                        units.Add(currentLine[1], newUnit);

                        unitsByAttack.Add(newUnit);

                        finalResult.AppendLine(string.Format("SUCCESS: {0} added!", currentLine[1]));
                    }
                    catch (Exception)
                    {
                        finalResult.AppendLine(string.Format("FAIL: {0} already exists!", currentLine[1]));
                    }
                }
                else if (currentLine[0] == "remove")
                {
                    try
                    {
                        var unit = units[currentLine[1]];
                        unitsByAttack.Remove(unit);
                        units.Remove(currentLine[1]);

                        finalResult.AppendLine(string.Format("SUCCESS: {0} removed!", currentLine[1]));
                    }
                    catch (Exception)
                    {
                        finalResult.AppendLine(string.Format("FAIL: {0} could not be found!", currentLine[1]));
                    }
                }
                else if (currentLine[0] == "find")
                {
                    var result = new StringBuilder("RESULT: ");

                    var resultingUnits = unitsByAttack
                                            .Where(u => u.Type == currentLine[1])
                                            .Take(10);

                    foreach (var unit in resultingUnits)
                    {
                        result.Append(string.Format("{0}[{1}]({2}), ", unit.Name, unit.Type, unit.Attack));
                    }

                    if (result.Length > 8)
                    {
                        result.Remove(result.Length - 2, 2);
                    }

                    finalResult.AppendLine(result.ToString());
                }
                else if (currentLine[0] == "power")
                {
                    var result = new StringBuilder("RESULT: ");

                    var resultingUnits = unitsByAttack.Take(int.Parse(currentLine[1]));

                    foreach (var unit in resultingUnits)
                    {
                        result.Append(string.Format("{0}[{1}]({2}), ", unit.Name, unit.Type, unit.Attack));
                    }

                    if (result.Length > 8)
                    {
                        result.Remove(result.Length - 2, 2);
                    }

                    finalResult.AppendLine(result.ToString());
                }

                input = Console.ReadLine();
            }

            Console.Write(finalResult);
        }
    }

    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }

        public int CompareTo(Unit other)
        {
            if (this.Attack.CompareTo(other.Attack) == 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            return this.Attack.CompareTo(other.Attack) * -1;
        }
    }
}