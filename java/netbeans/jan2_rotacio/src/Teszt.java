
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Scanner;

public class Teszt
{

    public static void main(String[] args) throws IOException
    {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String sor = br.readLine();
        String[] tokenek = sor.split(" ");
        Arrays.asList(tokenek);
        int[] t = new int[tokenek.length];

        for (int i = 0; i < tokenek.length; i++)
        {
            t[i] = Integer.parseInt(tokenek[i]);
        }

        Arrays.sort(t);

//        for (int i = 0; i < t.length; i++)
//        {
//            System.out.print(t[i] + " ");
//
//        }
        for (int i = 0; i < t.length; i++)
        {
            int r = 0;
            for (int j = 0; j < t.length; j++)
            {
                if (r == 0)
                {
                    System.out.print(t[(i + j) % t.length]);
                    r++;
                } else
                {
                    System.out.print(" " + t[(i + j) % t.length]);
                }
            }
            System.out.println();
        }

    }
}
