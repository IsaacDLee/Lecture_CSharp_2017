﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        class MyStack
        {
            int top;
            int[] intArr;

            public MyStack()
            {
                top = 0;
                intArr = new int[10];
            }

            public MyStack(int length)
            {
                top = 0;
                intArr = new int[length];
            }

            public void push(int val)
            {
                if (top < intArr.Length)
                    intArr[top++] = val;
                else
                    Console.WriteLine("stack is full!!");
            }

            public int pop()
            {
                if (top > 0)
                    return intArr[--top];
                else
                {
                    Console.WriteLine("stack is empty!!!");
                    return int.MinValue;
                }

            }
        }

        class MyQueue
        {
            int head;
            int tail;

            int[] intArr;

            public MyQueue()
            {
                head = -1;
                tail = 0;

                intArr = new int[10];
            }

            public MyQueue(int length)
            {
                head = 0;
                tail = 0;

                intArr = new int[length];
            }

        }

        class Node
        {
            public int val;
            public Node next;
        }

        class MyStackByGivenLL
        {
            LinkedList<int> buffer = new LinkedList<int>();

            public void push(int val)
            {
                buffer.AddLast(val);
            }

            public int pot()
            {
                if (buffer.Count == 0)
                {
                    Console.WriteLine("stack is full.");
                    return int.MaxValue;
                }
                else
                {
                    int returnVal = buffer.Last<int>();
                    buffer.RemoveLast();
                    return returnVal;
                }
            }
        }

        class MyStackByLinkedList
        {
            Node head = null;
            Node top = null;

            public void push(int val)
            {
                Node tmpNode = new Node();
                tmpNode.val = val;
                tmpNode.next = null;

                if (head != null)
                {
                    top.next = tmpNode;
                    top = tmpNode;
                }
                else
                {
                    head = tmpNode;
                    top = tmpNode;
                }
            }

            public int pop()
            {
                if (top != null)
                {
                    Node curNode = head;

                    if (head != top)
                    {
                        //for (; curNode.next != top; curNode = curNode.next) ;
                        for (; curNode.next != top;)
                            curNode = curNode.next;
                        int returnVal = top.val;

                        curNode.next = null;
                        top = curNode;

                        return returnVal;
                    }
                    else
                    {
                        int returnVal = top.val;
                        head = null;
                        top = null;

                        return returnVal;
                    }
                }
                else
                {
                    Console.WriteLine("stack is empty.");
                    return int.MaxValue;

                }

            }

        }

        class MyQueueByLinkedList
        {
            Node head = null;
            Node tail = null;

            public void enqueue(int val)
            {
                Node tmpNode = new Node();
                tmpNode.val = val;
                tmpNode.next = null;

                if (head == null)
                {
                    head = tmpNode;
                    tail = tmpNode;
                }
                else
                {
                    tail.next = tmpNode;
                    tail = tmpNode;
                }
            }

            public int dequeue()
            {
                if (head != null)
                {
                    int returnVal = head.val;

                    if (head == tail)
                        head = tail = null;
                    else
                        head = head.next;

                    return returnVal;
                }
                else
                {
                    Console.WriteLine("Queue is empty!!");
                    return int.MaxValue;
                }
            }
        }

        class BinaryTreeNode
        {
            public int val;
            public BinaryTreeNode left;
            public BinaryTreeNode right;

            public BinaryTreeNode()
            {
                val = 0;
                left = null;
                right = null;
            }

            public BinaryTreeNode(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }
        }

        class BinaryTree
        {
            BinaryTreeNode root;

            public void Insert(BinaryTreeNode parent, BinaryTreeNode left, BinaryTreeNode right)
            {
                parent.left = left;
                parent.right = right;

            }

            void TravelsByPre(BinaryTreeNode _root)
            {
                Console.Write(_root.val + " ");
                if (_root.left != null)
                    TravelsByPre(_root.left);
                if (_root.right != null)
                    TravelsByPre(_root.right);
            }

            public void TravelsByPre()
            {
                TravelsByPre(root);
            }

            void TravelsByIn(BinaryTreeNode _root)
            {
                if (_root.left != null)
                    TravelsByIn(_root.left);

                Console.Write(_root.val + " ");

                if (_root.right != null)
                    TravelsByIn(_root.right);
            }

            public void TravelsByIn()
            {
                TravelsByIn(root);
            }

            void TravelsByPost(BinaryTreeNode _root)
            {
                if (_root.left != null)
                    TravelsByPost(_root.left);

                if (_root.right != null)
                    TravelsByPost(_root.right);

                Console.Write(_root.val + " ");

            }


            public void TravelsByPost()
            {
                TravelsByPost(root);
            }

            public void SetRoot(BinaryTreeNode rootNode)
            {
                root = rootNode;
            }

        }

        class HeapNode
        {
            public int val;
            public HeapNode left;
            public HeapNode right;
            public HeapNode parent;

            public HeapNode()
            {
                val = 0;
                parent = null;
                left = null;
                right = null;
            }

            public HeapNode(int _val)
            {
                val = _val;
                parent = null;
                left = null;
                right = null;
            }
        }

        class HeapByLinked
        {
            HeapNode root;
            HeapNode dummy;
            HeapNode last;

            public HeapByLinked()
            {
                root = null;                
                last = null;
                dummy = new HeapNode();
            }

            void FindDummyPos()
            {
                HeapNode curNode = dummy;

                if (curNode.parent.left == dummy)
                {
                    dummy = new HeapNode();
                    
                    curNode.parent.right = dummy;
                    dummy.parent = curNode.parent;
                }
                else
                {
                    while (curNode.parent.left != curNode && curNode.parent != root)
                        curNode = curNode.parent;

                    if (curNode.parent.right == curNode)
                        curNode = curNode.parent.left;
                    else
                        curNode = curNode.parent.right;

                    while (curNode.left != null)
                        curNode = curNode.left;

                    dummy = new HeapNode();
                    
                    curNode.left = dummy;
                    dummy.parent = curNode;

                }

            }

            void MakeHeapFromLeaf()
            {
                HeapNode curNode = last;

                if ( curNode != root)
                {
                    while ( curNode.val > curNode.parent.val )
                    {
                        int tmp = curNode.val;
                        curNode.val = curNode.parent.val;
                        curNode.parent.val = tmp;
                                                
                        curNode = curNode.parent;
                        if (curNode == root)
                            break;
                    }
                }

            }

            public void Insert(int _val)
            {
                if (root == null)
                {
                    root = dummy;
                    root.val = _val;
                    last = root;
                    root.left = dummy = new HeapNode();
                    dummy.parent = root;
                }
                else
                {
                    last = dummy;
                    last.val = _val;
                    FindDummyPos();
                    MakeHeapFromLeaf();

                }
            }

            void FindLastPos()
            {
                HeapNode curNode = last;

                if ( last == root )
                {
                    root = null;
                    last = null;                    
                }
                else
                {
                    if (last.parent.right == last)
                        last = last.parent.left;
                    else
                    {
                        while ((curNode.parent.right != curNode) && (curNode.parent != root))
                            curNode = curNode.parent;

                        if (curNode.parent.left == curNode)
                            curNode = curNode.parent.right;
                        else
                            curNode = curNode.parent.left;

                        while (curNode.right != null)
                            curNode = curNode.right;

                        last = curNode;

                    }
                }
                
            }

            void MakeHeapFromRoot()
            {
                HeapNode curNode = root;

                while ( curNode.left != null || curNode.right != null )
                {
                    if ( curNode.left != null )
                    {
                        if ( curNode.right != null )
                        {
                            if (curNode.val < curNode.left.val)
                            {
                                if (curNode.left.val < curNode.right.val)
                                {
                                    int tmp = curNode.val;
                                    curNode.val = curNode.right.val;
                                    curNode.right.val = tmp;

                                    curNode = curNode.right;
                                }
                                else
                                {
                                    int tmp = curNode.val;
                                    curNode.val = curNode.left.val;
                                    curNode.left.val = tmp;

                                    curNode = curNode.left;
                                }
                            }
                            else if (curNode.val < curNode.right.val)
                            {
                                int tmp = curNode.val;
                                curNode.val = curNode.right.val;
                                curNode.right.val = tmp;

                                curNode = curNode.right;
                            }
                            else
                                break;
                        }
                        else
                        {
                            if (curNode.val < curNode.left.val)
                            {
                                int tmp = curNode.val;
                                curNode.val = curNode.left.val;
                                curNode.left.val = tmp;

                                curNode = curNode.left;
                            }
                            else
                                break;
                        }
                    }
                    else
                    {
                        if (curNode.val < curNode.right.val)
                        {
                            int tmp = curNode.val;
                            curNode.val = curNode.left.val;
                            curNode.left.val = tmp;

                            curNode = curNode.left;

                        }
                        else
                            break;
                    } 

                }
            }

            public int Delete()
            {
                if (root == null)
                {
                    Console.WriteLine("Heap is empty!!!");
                    return -1;
                }
                else
                {
                    int returnVal = root.val;
                    root.val = last.val;
                    if (dummy.parent.left == dummy)
                        dummy.parent.left = null;
                    else
                        dummy.parent.right = null;
                    dummy = last;
                    FindLastPos();
                    MakeHeapFromRoot();

                    return returnVal;
                }
            }

            void TravelsByPre(HeapNode _root)
            {
                if ( _root != dummy )
                    Console.Write(_root.val + " ");

                if (_root.left != null)
                    TravelsByPre(_root.left);
                if (_root.right != null)
                    TravelsByPre(_root.right);                
            }

            public void TravelsByPre()
            {
                TravelsByPre(root);
            }
        }


        static void Main(string[] args)
        {
            // travels binary tree
            BinaryTreeNode tmpNode1 = new BinaryTreeNode(1);
            BinaryTreeNode tmpNode2 = new BinaryTreeNode(2);
            BinaryTreeNode tmpNode3 = new BinaryTreeNode(3);
            BinaryTreeNode tmpNode4 = new BinaryTreeNode(4);
            BinaryTreeNode tmpNode5 = new BinaryTreeNode(5);
            BinaryTreeNode tmpNode6 = new BinaryTreeNode(6);
            BinaryTreeNode tmpNode7 = new BinaryTreeNode(7);

            BinaryTree bTree = new BinaryTree();

            bTree.SetRoot(tmpNode1);
            bTree.Insert(tmpNode1, tmpNode2, tmpNode3);
            bTree.Insert(tmpNode2, tmpNode4, tmpNode5);
            bTree.Insert(tmpNode3, tmpNode6, tmpNode7);

            bTree.TravelsByPre();
            Console.WriteLine();

            bTree.TravelsByIn();
            Console.WriteLine();

            bTree.TravelsByPost();
            Console.WriteLine();

            // heap test
            HeapByLinked myHeap = new HeapByLinked();

            myHeap.Insert(0);
            myHeap.Insert(1);
            myHeap.Insert(2);
            myHeap.Insert(3);
            myHeap.Insert(4);
            myHeap.Insert(5);
            myHeap.Insert(6);


            myHeap.TravelsByPre();
            Console.WriteLine();

            Console.WriteLine(myHeap.Delete());
            myHeap.TravelsByPre();
            Console.WriteLine();

            


        }
    }
}
