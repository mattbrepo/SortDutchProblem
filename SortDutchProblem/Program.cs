using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortDutchProblem
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] xs = new int[] {2, 0, 1, 2};
      SortDutchProblem(xs);
      xs = new int[] { 0, 1, 2, 0, 2, 2, 1, 0, 0, 2, 0, 0, 2 };
      SortDutchProblem(xs);
    }

    private static void SortDutchProblem(int[] xs)
    {
      int count = xs.Length;
      int i = 0;
      int last1 = -1;
      while (i < count)
      {
        int x = xs[i];
        if (x == 0)
        {
          i++;
          continue;
        }

        //x == 1 || 2
        count--;
        swap(xs, i, count);

        if (x == 1)
        {
          if (last1 == -1) last1 = count;
          continue;
        }

        //x == 2
        if (last1 > -1)
        {
          swap(xs, count, last1);
          last1 = count;
        }
      }
    }

    private static void swap(int[] xs, int i, int j)
    {
      int tmp = xs[i];
      xs[i] = xs[j];
      xs[j] = tmp;
    }
  }
}
