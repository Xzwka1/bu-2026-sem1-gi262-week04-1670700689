using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
             //LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            //string[] playername = new string[13];
            
            
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();

            linkedlist.AddLast("Node 1");
            linkedlist.AddLast("Node 2");
            linkedlist.AddFirst("Node 0");
            LinkedListNode<string> firstNode = linkedlist.First;

            Debug.Log("first:" + firstNode.Value);

            LinkedListNode<string> lastNode = linkedlist.First;
            Debug.Log("first:" + lastNode.Value);

            Debug.Log("firstNode.Next: " + firstNode.Next.Value);
            Debug.Log("firstNode.Next: " + firstNode.Next.Next.Value);

            Debug.Log("lastNode.Previous: " + firstNode.Previous.Value);
            Debug.Log("lastNode.Previous.Previous: " + firstNode.Previous.Previous.Value);

            if (firstNode.Previous == null) Debug.Log("firstNode.Previous == null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next == null");

            linkedlist.AddAfter(firstNode, "Node 0.5");
            linkedlist.AddBefore(lastNode, "Node 1.5");
            //linkedlistNode<string> node1 = linkedlist.Find("Node 1");
            linkedlist.Remove("Node 1");
            linkedlist.Remove("node1");
            linkedlist.RemoveLast();
            linkedlist.RemoveFirst();
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
           Dictionary<string, int> inv = new Dictionary<string, int>();
            var inv2 = new Dictionary<string , int>();
            inv.Add("Potion", 1);
            inv.Add("Apple", 10);
            inv["Banana"] = 5;

            var pickItem = "Sword";
            inv[pickItem] = 1;

            foreach (KeyValuePair<string, int> pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"{key} Value: {value}");
            }

            var appleExits = inv.ContainsKey("Apple");
            Debug.Log(appleExits);
            var keyExits = inv.ContainsKey("key");
            Debug.Log(keyExits);

            inv.Remove("Apple"); 
            foreach (var pair in inv)
            {
                string key = (pair.Key);
                int value = pair.Value;
                Debug.Log($"{key} Value: {value}");
            }

        }

        #endregion
    }
}
