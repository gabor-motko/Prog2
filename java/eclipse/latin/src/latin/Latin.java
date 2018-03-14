package latin;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;

public class Latin
{
	public static void main(String args[])
	{
		try (BufferedReader r = new BufferedReader(new FileReader("latin.txt"))) 	// = using(){...}
		{
			;
		}
		catch(Exception ex)
		{
			;
		}
		int[][] m = new int[3][3];
		for(int i = 0; i < m.length; ++i)
		{
			System.out.println(m[i].length);
			for(int j = 0; j < m[i].length; ++j)
			{
				
			}
		}
		int[][] m2 = new int[3][];
		for(int i = 0; i < m2.length; ++i)
		{
			m2[i] = new int[i+1];
			System.out.println(m2[i].length);
		}
	}
}
