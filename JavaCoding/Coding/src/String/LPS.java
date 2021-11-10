package String;
import static java.lang.System.out;
import java.util.ArrayList;

public class LPS {
	public int function(String s)
	{
		ArrayList<String> suffix = new ArrayList<>();
		ArrayList<String> prefix = new ArrayList<>();
		
		for(int i = 0; i < s.length(); i++)
		{
			if(i == 0)
			{
				suffix.add(Character.toString(s.charAt(i)));
			}
			else
			{
				suffix.add(suffix.get(i-1) + Character.toString(s.charAt(i)));
			}
		}
		
		for(int i = s.length()-1; i >= 0; i--)
		{
			if(i == s.length()-1)
			{
				prefix.add(Character.toString(s.charAt(i)));
			}
			else
			{
				prefix.add(Character.toString(s.charAt(i)) + prefix.get(prefix.size()-1));
			}
		}
		int max = 0;
		for(int i = 0; i < suffix.size(); i++)
		{
			if(suffix.get(i).equals(prefix.get(i)) && i != suffix.size()-1)
			{
				max = i+1;
			}
		}
		return max;
	}
}
