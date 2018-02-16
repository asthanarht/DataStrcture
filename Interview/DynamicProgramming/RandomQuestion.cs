// "abc","bc","acd",dba",dtr,

using System;
using System.Collections.Generic;
namespace Interview
{
	public class AutoComplete
	{

	    class Node
		{
			public string prefix;
			public Dictionary<char, Node> dict;
			public bool isWord;
			public Node(string prefix)
			{
				this.prefix = prefix;
				this.dict = new Dictionary<char, Node>();
			}

		}

	   Node trie;

		public AutoComplete(string[] words)
		{
			trie = new Node("");
			foreach (var word in words)
			{
				InsertWord(word);
			}
		}

		private void InsertWord(string word)
		{
			Node curr = trie;
			for (int i = 0; i < word.Length; i++)
			{
				if (!curr.dict.ContainsKey(word[i]))
				{
					curr.dict.Add(word[i], new Node(word.Substring(0, i + 1)));
				}
				curr = curr.dict[word[i]];
				if (i == word.Length - 1)
				{
					curr.isWord = true;
				}
			}
		}

		public List<string> GetPrefix(string pre)
		{
			var prefixList = new List<string>();

			Node curr = trie;
			foreach (var c in pre)
			{
				if (curr.dict.ContainsKey(c))
					curr = curr.dict[c];
				else
					return prefixList;
			}
			FindPrefix(curr, prefixList);
			return prefixList;
		}

		private void FindPrefix(Node n,  List<string> prefixList)
		{
			if (n.isWord)
				prefixList.Add(n.prefix);


			foreach (var item in n.dict.Keys)
			{
				FindPrefix(n.dict[item], prefixList);
			}
		}
	  }


}
