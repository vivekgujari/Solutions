import static java.lang.System.out;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

import LinkedList.LinkedList;
import LinkedList.Node;
import Arrays.Alternate_pos_neg;
import Arrays.ThirdLargest;
import String.AddBinaryStrings;
import String.DecodeString;
import String.FirstNonRepeatingChar;
import String.LPS;
import Trie.Trie;

public class Program {

	public static void main(String[] args) {
		Trie T = new Trie();
		T.insert("mouse");
		T.insert("monitor");
		T.insert("moneypot");
		out.print(T.search("moneypo") + "\n");
		T.crawl("mo");
		Collections.sort(T.output);
		out.print(T.output.toString()+"\n");
		out.print("End of main program");
	}
	
	public String Compare(String s1, String s2)
	{
		if(s1.compareTo(s2) > 0)
			return s1;
		else
			return s2;
	}

}
