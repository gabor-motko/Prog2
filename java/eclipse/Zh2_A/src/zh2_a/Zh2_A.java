package zh2_a;
import java.util.*;

public class Zh2_A 
{
	static Map<String, String> dict;
	public static void main(String[] args)
	{
		dict = new HashMap<String, String>();
		Scanner sc = new Scanner(System.in);
		
        String line;
        while(sc.hasNextLine())
        {
        	line = sc.nextLine();
            String[] tok = line.split(" ");
            if(tok.length == 1)
            {
                if(dict.containsKey(tok[0]))
                {
                    System.out.println(dict.get(tok[0]));
                }
                else
                {
                    System.out.println("unknown");
                }
            }
            else if(tok.length == 2)
            {
                if(dict.containsKey(tok[0]))
                {
                    if(dict.get(tok[0]).length() > tok[1].length())
                    	dict.replace(tok[0], tok[1]);
                }
                else
                {
                    dict.put(tok[0], tok[1]);
                }
            }
            else
            {

            }
        }
        if(sc != null)
        	sc.close();
	}
}
