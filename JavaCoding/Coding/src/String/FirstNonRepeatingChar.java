package String;

public class FirstNonRepeatingChar {
	public char function(String s)
	{
		int[] arr = new int[256];
		for(int i = 0; i < s.length(); i++)
		{
			arr[s.charAt(i)] += 1;
		}
		int j = 0;
		for(; j < s.length(); j++)
		{
			if(arr[s.charAt(j)] == 1)
			{
				break;
			}
		}
		return s.charAt(j);
	}
}
