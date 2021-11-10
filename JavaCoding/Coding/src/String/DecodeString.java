package String;
import java.util.*;

public class DecodeString {
	public String function(String s)   /// 3[b2[ac]]
	{
		Stack<Integer> num = new Stack<>();
		Stack<String> str = new Stack<>();
		
		String temp = "";
		String result = "";
		
		for(int i = 0; i < s.length(); i++)
		{
			if(Character.isDigit(s.charAt(i)))
			{
				num.push(Character.getNumericValue(s.charAt(i)));
				continue;
			}
			if(s.charAt(i) == '[')
			{
				i++;
				while(!Character.isDigit(s.charAt(i)) && s.charAt(i) != '[' && s.charAt(i) != ']')
				{
					temp += String.valueOf(s.charAt(i++));
				}
				str.push(temp);
				temp = "";
				i--;
			}
			else if(s.charAt(i) == ']')
			{
				int n = num.pop();
				String t = str.pop() + result;
				result = "";
				for(int j = 0; j < n; j++) {
					result += t;
				}
			}
		}
		return result;
	}
}
