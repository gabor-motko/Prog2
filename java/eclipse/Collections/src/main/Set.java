package main;

import java.util.*;

class Numbah implements Comparable<Numbah>
{
	@Override
	public String toString()
	{
		return Integer.toString(this.value);
	}

	int value;

	public Numbah(int value)
	{
		super();
		this.value = value;
	}

	@Override
	public int hashCode()
	{
		return this.value;
	}

	@Override
	public boolean equals(Object obj)
	{
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Numbah other = (Numbah) obj;
		if (value != other.value)
			return false;
		return true;
	}

	@Override
	public int compareTo(Numbah arg0)
	{
		return Integer.compare(this.value, arg0.value);
	}
	
	
}

public class Set
{
	
	public static void main(String[] args)
	{
		HashSet<Numbah> hash = new HashSet<>();
		for(int i = 0; i < 10; ++i)
		{
			hash.add(new Numbah(i+1));
			hash.add(new Numbah(i+1));
		}
		System.out.println(hash);
		
		TreeSet<Numbah> tree = new TreeSet<>();
		for(int i = 0; i < 10; ++i)
		{
			tree.add(new Numbah(i+1));
		}
		System.out.println(tree);
		
		Map<String, Integer> hashmap = new HashMap<>();
		
	}
	
}
