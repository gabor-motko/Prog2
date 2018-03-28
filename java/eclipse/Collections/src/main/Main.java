package main;

import java.util.ArrayList;
import java.util.List;

public class Main
{
	
	public static void main(String[] args)
	{
		List<Integer> l = new ArrayList<Integer>();
		for(int i = 0; i < 10; ++i)
			l.add(i+1);
		System.out.println(l);
	}
	
}
