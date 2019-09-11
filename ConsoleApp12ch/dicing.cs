using System;

public class DiceSelection
{
	public int Calculating(int i, int j )
	{
        int pc = 0;
        int dices = i;
        int faces = j;
        var rand = new Random();
        for (int n=0; n<dices; n++)
        {
            pc += rand.Next(1, j+1);
        }
        return pc;


    }
}
