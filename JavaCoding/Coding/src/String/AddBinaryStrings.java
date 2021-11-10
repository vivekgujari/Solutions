package String;

import java.util.ArrayList;

public class AddBinaryStrings {
	public String function(String s1, String s2)
	{
		if(s1.length() == 0 && s2.length() == 0)
		{
			return null;
		}
		StringBuilder result = new StringBuilder("");
		int carry = 0;
		ArrayList<String> list = new ArrayList<>();
		int i = s1.length();
		int j = s2.length();
		int k = Math.min(i, j);
		for(int x = 0; x < k; x++)
		{
			int num1 = Character.getNumericValue(s1.charAt(i-1-x));
			int num2 = Character.getNumericValue(s2.charAt(j-1-x));
			int sum = num1 + num2 + carry;
			if(sum == 3)
			{
				list.add("1");
				carry = 1;
			}
			else if(sum == 2)
			{
				list.add("0");
				carry = 1;
			}
			else
			{
				list.add(String.valueOf(sum));
				carry = 0;
			}
		}
		
		while(k < i)
		{
			int d = Character.getNumericValue(s1.charAt(i-1-k));
			int sum = d + carry;
			if(sum == 2)
			{
				list.add("0");
				carry = 1;
			}
			else {
				list.add(Integer.toString(sum));
				carry = 0;
			}
			k++;
		}
		while(k < j)
		{
			int sum = Character.getNumericValue(s2.charAt(j-1-k)) + carry;
			if(sum == 2)
			{
				list.add("0");
				carry = 1;
			}
			else {
				list.add(Integer.toString(sum));
				carry = 0;
			}
			k++;
		}
		if(carry == 1)
			list.add("1");
		
		for(int z = list.size()-1; z>= 0; z--)
		{
			result.append(list.get(z));
		}
		
		while(true)
		{
			if(result.charAt(0) == '0')
				result.deleteCharAt(0);
			else
				break;
		}
		return result.substring(0);
	}
}
