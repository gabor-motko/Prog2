package main;

import java.io.*;
import java.util.*;

public class FileHandling
{
	public static void main1(String[] args)
	{
		List<String> lines = new LinkedList<String>();
		Scanner s = null;
		try
		{
			s = new Scanner(new File("text.txt"));
			while(s.hasNextLine())
			{
				lines.add(s.nextLine());
			}
			
			Iterator<String> i = lines.iterator();
			while(i.hasNext())
				System.out.println(i.next());
		}
		catch(FileNotFoundException ex)
		{
			ex.printStackTrace();
		}
		finally
		{
			if(s != null)
				s.close();
		}
	}
	
	public static void main2()
	{
		List<String> lines = new LinkedList<String>();
		BufferedReader reader = null;
		try
		{
			reader = new BufferedReader(new FileReader("text.txt"));
			String line;
			while((line = reader.readLine()) != null)
			{
				lines.add(line);
			}
		}
		catch(IOException ex)
		{
			ex.printStackTrace();
		}
		finally
		{
			if(reader != null)
			{
				try
				{
					reader.close();
				} catch (IOException ex)
				{
					ex.printStackTrace();
				}
			}
		}
		for(String line : lines)
		{
			System.out.println(line);
		}
	}

public static void main()
{
	List<String> lines = new LinkedList<String>();
	try (BufferedReader reader = new BufferedReader(new FileReader("text.txt")))
	{
		String line;
		while((line = reader.readLine()) != null)
		{
			lines.add(line);
		}
	}
	catch(IOException ex)
	{
		ex.printStackTrace();
	}
	for(String line : lines)
	{
		System.out.println(line);
	}
}
}
