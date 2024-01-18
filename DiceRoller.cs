using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class DiceRoller
{
    private readonly Random random = new Random();

    public int[] SimulateDiceRolls(int numberOfRolls)
    {
        int[] results = new int[13];

        for (int i = 0; i < numberOfRolls; i++)
        {
            int sum = random.Next(1, 7) + random.Next(1, 7);
            results[sum]++;
        }

        return results;
    }
}


