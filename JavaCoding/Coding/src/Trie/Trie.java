package Trie;
import java.util.*;

public class Trie {
	public class TrieNode{
		public String value;
		public HashMap<String, TrieNode> children;
		public boolean end;
		public TrieNode(String value)
		{
			this.value = value;
			this.end = false;
			children = new HashMap<>();
			
		}
		
		@Override
		public String toString()
		{
			return "TrieNode -> " + this.value;
		}
		
	}
	public TrieNode root;
	
	public Trie()
	{
		root = new TrieNode(" ");
	}
	public void insert(String word)
	{
		TrieNode a = root;
		for(int i = 0; i < word.length(); i++)
		{
			String k = String.valueOf(word.charAt(i));
			if(a.children.get(k) == null)
			{
				a.children.put(k, new TrieNode(k));
			}
			a = a.children.get(k);
		}
		a.end = true;
	}
	
	public boolean search(String word)
	{
		TrieNode a = root;
		for(int i = 0; i < word.length(); i++)
		{
			String k = String.valueOf(word.charAt(i));
			if(a.children.get(k) == null)
				return false;
			a = a.children.get(k);
		}
		return a.end;
	}
	
	/// web crawl after typing 2 letters in search engine
	public ArrayList<String> output;
	public void crawl(String word)
	{
		output = new ArrayList<String>();
		TrieNode lastNode = getLastNode(word.substring(0, 2));
		crawlfunction(lastNode, word.substring(0, 2), output);
	}
	
	public void crawlfunction(TrieNode node, String prefix, ArrayList<String> output)
	{
		if(node.end == true)
		{
			output.add(prefix);
		}
		for(var n : node.children.values())
		{
			crawlfunction(n, prefix + n.value, output);
		}
	}
	
	public TrieNode getLastNode(String prefix)
	{
		TrieNode output = root;
		for(int i = 0; i < prefix.length(); i++)
		{
			String k = String.valueOf(prefix.charAt(i));
			if(output.children.get(k) == null)
				return null;
			output = output.children.get(k);	
		}
		return output;
	}

}
