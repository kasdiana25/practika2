/* Задание1
using System;
Console.WriteLine("Введите символы: ");
string j = "abbccd";
string s = Console.ReadLine();
int count = 0;
foreach (var n in j)
{
    foreach (var m in s)
    {
        if (n == m)
        {
            count++;
        }
    }
}
Console.WriteLine(count); */

/* Задание2

using System;
using System.Collections.Generic;

class Program
{
    static void findСombinations(int[] candidates, int target, List<int> flowing, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(flowing));
            return;
        }

        for (int i = 0; i < candidates.Length; i++)
        {
            if (target - candidates[i] >= 0)
            {
                flowing.Add(candidates[i]);
            }
        }
    }

    static void Main()
    {
        int[] candidates = new[] { 2, 5, 2, 1, 2 };
        int target = 5;
        List<List<int>> result = new List<List<int>>();
        List<int> flowing = new List<int>();
        findСombinations(candidates, target, 0, flowing, result);
        foreach (var n in result)
        {
            Console.WriteLine(n);
        }
    }
}*/

using System;
using System.Collections.Generic;

class Program
{
    static void FindCombinations(List<List<int>> result, List<int> current, int[] candidates, int target, int startIndex)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue; // Skip duplicates
            }

            if (target - candidates[i] >= 0)
            {
                current.Add(candidates[i]);
                FindCombinations(result, current, candidates, target - candidates[i], i + 1);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    static void Main()
    {
        int[] candidates = new[] { 10, 1, 2, 7, 6, 1, 5 };
        int target = 8;
        List<List<int>> result = new List<List<int>>();

        Array.Sort(candidates);
        FindCombinations(result, new List<int>(), candidates, target, 0);

        foreach (var combination in result)
        {
            foreach (var num in combination)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}


/* Задание3

using System;
int[] nums = { 1, 1, 2, 3, 4 };
bool a = false;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            a = true;
        }
        else
        {
            a = false;
        }
    }
}
Console.WriteLine(a);*/



