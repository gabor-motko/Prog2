package shell;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import shell.Shell;

public class HangmanShell extends Shell
{
	List<String> words;
	int count;
	String word;
	String correct;
	Set<Character> guesses;

	
	boolean print() throws PhaseNumberOutOfBoundsException
	{
		format("%s%n", getHangman(count));
		for(int i = 0; i < word.length(); ++i)
		{
			if(guesses.contains(word.charAt(i)))
				format("%c", word.charAt(i));
			else
				format("*");
		}
		format("%n");
		return true;
	}
	
	public HangmanShell()
	{
		super();
		this.words = new ArrayList<String>();
		this.guesses = new HashSet<Character>();
		
		addCommand(new Command("load")
		{
			@Override
			public boolean execute(String... args)
			{
				if(args.length != 1)
					return false;
				
				try(BufferedReader br = new BufferedReader(new FileReader(args[0])))
				{
					String line;
					words.clear();
					while((line = br.readLine()) != null)
					{
						words.add(line);
					}
				}
				catch(Exception ex)
				{
					return false;
				}
				return true;
			}
		});
		
		addCommand(new Command("new")
		{
			
			@Override
			public boolean execute(String... args)
			{
				if(args.length != 0 || words.size() <= 0)
					return false;
				
				count = 0;
				Collections.shuffle(words);
				word = words.get(0);
				
				return true;
			}
		});
		
		addCommand(new Command("print")
		{
			@Override
			public boolean execute(String... args)
			{
				if(args.length != 0 || words.size() <= 0 || word == null)
					return false;
				try
				{
					return print();
				} catch (PhaseNumberOutOfBoundsException e)
				{
					return false;
				}
			}
		});
		
		addCommand(new Command("letter")
		{
			
			@Override
			public boolean execute(String... args)
			{
				char c;
				if(args.length != 1 || args[0].length() != 1 || words.size() <= 0 || word == null || count >= 5 || guesses.contains(c = args[0].toUpperCase().charAt(0)) || !Character.isLetter(c))
				{
					return false;
				}
				
				guesses.add(c);
				if(word.indexOf(c) < 0)
					++count;
				try
				{
					print();
				} catch (PhaseNumberOutOfBoundsException e)
				{
				}
				return true;
			}
		});
	}
}
