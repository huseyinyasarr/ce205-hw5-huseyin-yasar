using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/**
 * @file ce205-hw4-trie.cs
 * @author Alper SAHIN, HUSEYIN YASAR
 * @date 29 December 2022
 *
 * @brief <b> HW-5 Functions </b>
 *
 * HW-5 Sample Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */
namespace ce205_hw5_trie
{
    public static class Class1
    {
     

        public class Trie : IEnumerable<TrieNode>
        {

            private TrieNode root;

            public Trie()
            {
                root = new TrieNode();

            }

            /**
            *   @name   Insert
            *
            *   @brief  Adds the input to the trie by creating a child node in the tree
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/
            public void Insert(string word)
            {
                TrieNode current = root;

                foreach (char ch in word)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        current.Children[ch] = new TrieNode(ch, current);
                    }
                    current = current.Children[ch];
                }
                current.IsEndOfWord = true;
            }

            /**
            *   @name   GetWords
            *
            *   @brief  takes a prefix as input and returns all the words in the trie that start with that prefix.
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/

            public IEnumerable<string> GetWords(string prefix)
            {
                // First, find the node related to the given prefix.
                TrieNode current = root;

                for (int i = 0; i < prefix.Length; i++)
                {
                    char ch = prefix[i];
                    if (!current.Children.TryGetValue(ch, out TrieNode node))
                    {
                        yield break;
                    }
                    current = node;
                }

                Queue<TrieNode> queue = new Queue<TrieNode>();
                queue.Enqueue(current);

                // Scan the nodes in the queue.
                while (queue.Count > 0)
                {
                    TrieNode node = queue.Dequeue();

                    if (node.IsEndOfWord)
                    {
                        yield return GetWord(node);
                    }

                    foreach (var child in node.Children.Values)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            /**
            *   @name   GetWord
            *
            *   @brief  This method returns the word equivalent of the given node.
            *
            *   @param  [in] node [\b string]  is the node
            **/
            private string GetWord(TrieNode node)
            {
                // Create a stack.
                Stack<char> stack = new Stack<char>();

                while (node != root)
                {
                    stack.Push(node.Value);
                    node = node.Parent;
                }
                return new string(stack.ToArray());
            }


            /**
            *   @name   Delete
            *
            *   @brief  remove word from the trie
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/

            public bool Delete(string word)
            {
                return Delete(root, word, 0);
            }

            // for deleting a word from the Trie.
            private bool Delete(TrieNode current, string word, int index)
            {
                if (index == word.Length)
                {
                    if (!current.IsEndOfWord)
                    {
                        return false;
                    }
                    current.IsEndOfWord = false;
                    return current.Children.Values.All(node => node == null);
                }
                char ch = word[index];
                TrieNode nodeToDelete = current.Children[ch];
                if (nodeToDelete == null)
                {
                    return false;
                }
                bool shouldDeleteCurrentNode = Delete(nodeToDelete, word, index + 1) && !nodeToDelete.IsEndOfWord;

                if (shouldDeleteCurrentNode)
                {
                    current.Children.Remove(ch);
                    return current.Children.Values.All(n => n == null);
                }

                return false;
            }

            /**
            *   @name   GetEnumerator
            *
            *   @brief  returns an enumerator that allows the trie to be traversed in a depth-first fashion.
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/
            public IEnumerator<TrieNode> GetEnumerator()
            {
                // Create a queue to hold the TrieNodes that need to be processed
                Queue<TrieNode> queue = new Queue<TrieNode>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    TrieNode current = queue.Dequeue();
                    yield return current;

                    foreach (var child in current.Children.Values)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public IEnumerable<TrieNode> GetNodes()
            {
                Queue<TrieNode> queue = new Queue<TrieNode>();
                // Enqueue the root node
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    // Dequeue the next node
                    TrieNode current = queue.Dequeue();
                    yield return current;
                    foreach (var child in current.Children.Values)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }




        }

        public class TrieNode
        {
            // The value of the current node.
            public char Value { get; set; }
            // The parent node of the current node.
            public TrieNode Parent { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; }
            public bool IsEndOfWord { get; set; }

            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
            }
            public TrieNode(char value, TrieNode parent)
            {
                Value = value;
                Parent = parent;
                Children = new Dictionary<char, TrieNode>();
            }
        }





    }
}
