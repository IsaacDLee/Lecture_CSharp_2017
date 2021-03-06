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

            public void push(int _val)
            {
                if (top < intArr.Length)
                    intArr[top++] = _val;
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

            public void push(int _val)
            {
                buffer.AddLast(_val);
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

            public void push(int _val)
            {
                Node tmpNode = new Node();
                tmpNode.val = _val;
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

            public void enqueue(int _val)
            {
                Node tmpNode = new Node();
                tmpNode.val = _val;
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
            public BinaryTreeNode parent;

            public BinaryTreeNode()
            {
                val = 0;
                left = null;
                right = null;
                parent = null;
            }

            public BinaryTreeNode(int _val)
            {
                val = _val;
                left = null;
                right = null;
                parent = null;
            }
        }

        class BinaryTree
        {
            protected BinaryTreeNode root;

            public void Insert(BinaryTreeNode parent, BinaryTreeNode left, BinaryTreeNode right)
            {
                parent.left = left;
                parent.right = right;
                left.parent = parent;
                right.parent = parent;


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
                Console.WriteLine();
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
                Console.WriteLine();
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
                Console.WriteLine();
            }

            public void SetRoot(BinaryTreeNode rootNode)
            {
                root = rootNode;
            }

        }

        class BSTDerivedBT : BinaryTree
        {
            public void Insert(int _val)
            {
                if (root == null)
                    root = new BinaryTreeNode(_val);
                else
                {
                    BinaryTreeNode curNode = root;

                    while (true)
                    {
                        if (curNode.val > _val)
                        {
                            if (curNode.left == null)
                            {
                                curNode.left = new BinaryTreeNode(_val);
                                curNode.left.parent = curNode;
                                break;
                            }
                            else
                                curNode = curNode.left;
                        }
                        else if (curNode.val < _val)
                        {
                            if (curNode.right == null)
                            {
                                curNode.right = new BinaryTreeNode(_val);
                                curNode.right.parent = curNode;
                                break;
                            }
                            else
                                curNode = curNode.right;
                        }
                    }

                }
            }

            public void Delete(int _val)
            {
                BinaryTreeNode curNode = root;

                if (curNode == null)
                    Console.WriteLine("BST is empty!!!");
                else
                {
                    while (true)
                    {
                        if (curNode.val == _val)
                        {
                            if (curNode.left != null)
                            {
                                if (curNode.right != null)
                                {
                                    BinaryTreeNode leftMaxNode = curNode.left;

                                    while (leftMaxNode.right != null)
                                        leftMaxNode = leftMaxNode.right;

                                    curNode.val = leftMaxNode.val;
                                    if (leftMaxNode.left != null)
                                    {
                                        leftMaxNode.left.parent = leftMaxNode.parent;
                                        leftMaxNode.parent.right = leftMaxNode.left;
                                    }
                                    else
                                        leftMaxNode.parent.right = null;

                                }
                                else
                                {
                                    curNode.left.parent = curNode.parent;

                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = curNode.left;
                                    else
                                        curNode.parent.right = curNode.left;
                                }
                            }
                            else
                            {
                                if (curNode.right != null)
                                {
                                    curNode.right.parent = curNode.parent;
                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = curNode.right;
                                    else
                                        curNode.parent.right = curNode.right;
                                }
                                else
                                {
                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = null;
                                    else
                                        curNode.parent.right = null;
                                }
                            }
                            break;
                        }
                        else if (curNode.val > _val)
                        {
                            if (curNode.left == null)
                            {
                                Console.WriteLine(_val + " is not BST!!!");
                                break;
                            }
                            else
                                curNode = curNode.left;
                        }
                        else
                        {
                            if (curNode.right == null)
                            {
                                Console.WriteLine(_val + " is not BST!!!");
                                break;
                            }
                            else
                                curNode = curNode.right;

                        }

                    }
                }

            }

            public bool Search(int _val)
            {

                BinaryTreeNode curNode = root;

                if (curNode == null)
                    return false;
                else
                {
                    while (curNode != null)
                    {
                        if (curNode.val == _val)
                            return true;
                        else if (curNode.val > _val)
                            curNode = curNode.left;
                        else
                            curNode = curNode.right;
                    }

                    return false;
                }
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

                if (curNode != root)
                {
                    while (curNode.val > curNode.parent.val)
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

                if (last == root)
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

                while (curNode.left != null )
                {
                    if (curNode.right != null)
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
                            }

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
                if (_root != dummy)
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


        class HeapByArray
        {
            int[] buffer;
            int last;

            public HeapByArray()
            {
                buffer = new int[100];
                last = -1;
            }
            public HeapByArray(int length)
            {
                buffer = new int[length];
                last = -1;
            }

            public void Insert(int _val)
            {
                buffer[++last] = _val;

                if ( last > 0 )
                {
                    int curIndex = last;
                    int parentIndex = (last - 1) / 2;

                    while (buffer[curIndex] > buffer[parentIndex])
                    {
                        int tmp = buffer[curIndex];
                        buffer[curIndex] = buffer[parentIndex];
                        buffer[parentIndex] = tmp;

                        if (parentIndex != 0)
                        {
                            curIndex = parentIndex;
                            parentIndex = (parentIndex - 1) / 2;
                        }
                        else
                            break;                        
                    }
                }
            }

            public int Delete()
            {

                if (last < 0)
                {
                    Console.WriteLine("Heap is empty!!!");
                    return 0;
                }
                else
                {
                    int returnVal = buffer[0];
                    buffer[0] = buffer[last--];

                    int curIndex = 0;
                    int leftChildIndex = curIndex * 2 + 1;
                    int rightChildIndex = leftChildIndex + 1;

                    while ( leftChildIndex <= last )
                    {
                        if ( rightChildIndex <= last )
                        {
                            if (buffer[curIndex] < buffer[leftChildIndex])
                            {
                                if ( buffer[leftChildIndex] < buffer[rightChildIndex] )
                                {
                                    int tmp = buffer[curIndex];
                                    buffer[curIndex] = buffer[rightChildIndex];
                                    buffer[rightChildIndex] = tmp;

                                    curIndex = rightChildIndex;
                                    leftChildIndex = curIndex * 2 + 1;
                                    rightChildIndex = leftChildIndex + 1;
                                }
                                else
                                {
                                    int tmp = buffer[curIndex];
                                    buffer[curIndex] = buffer[leftChildIndex];
                                    buffer[leftChildIndex] = tmp;

                                    curIndex = leftChildIndex;
                                    leftChildIndex = curIndex * 2 + 1;
                                    rightChildIndex = leftChildIndex + 1;
                                }
                            }
                            else if (buffer[curIndex] < buffer[rightChildIndex])
                            {
                                int tmp = buffer[curIndex];
                                buffer[curIndex] = buffer[rightChildIndex];
                                buffer[rightChildIndex] = tmp;

                                curIndex = rightChildIndex;
                                leftChildIndex = curIndex * 2 + 1;
                                rightChildIndex = leftChildIndex + 1;
                            }
                            else
                                break;
                        }
                        else
                        {
                            if ( buffer[curIndex] < buffer[leftChildIndex])
                            {
                                int tmp = buffer[curIndex];
                                buffer[curIndex] = buffer[leftChildIndex];
                                buffer[leftChildIndex] = tmp;                                
                            }
                            break;
                        }
                    }

                    return returnVal;
                }
            }

            public void Print()
            {
                for (int i = 0; i <= last; i++)
                    Console.Write(buffer[i] + ", ");
                Console.WriteLine();
            }
        }


        class BSTNode
        {
            public int val;
            public BSTNode left;
            public BSTNode right;
            public BSTNode parent;

            public BSTNode()
            {
                val = 0;
                parent = null;
                left = null;
                right = null;
            }

            public BSTNode(int _val)
            {
                val = _val;
                parent = null;
                left = null;
                right = null;
            }

        }

        class BST
        {
            BSTNode root;
            
            public BST()
            {
                root = null;                
            }

            public void Insert(int _val)
            {
                if ( root == null )
                    root = new BSTNode(_val);
                else
                {
                    BSTNode curNode = root;

                    while ( true )
                    {
                        if (curNode.val > _val)
                        {
                            if (curNode.left == null)
                            {
                                curNode.left = new BSTNode(_val);
                                curNode.left.parent = curNode;
                                break;
                            }
                            else
                                curNode = curNode.left;
                        }
                        else if (curNode.val < _val)
                        {
                            if (curNode.right == null)
                            {
                                curNode.right = new BSTNode(_val);
                                curNode.right.parent = curNode;
                                break;
                            }
                            else
                                curNode = curNode.right;
                        }
                    }

                }
            }

            public void Delete(int _val)
            {
                BSTNode curNode = root;

                if (curNode == null)
                    Console.WriteLine("BST is empty!!!");
                else
                {
                    while ( true )
                    {
                        if ( curNode.val == _val)
                        {
                            if ( curNode.left != null )
                            {
                                if ( curNode.right != null )
                                {
                                    BSTNode leftMaxNode = curNode.left;

                                    while (leftMaxNode.right != null)
                                        leftMaxNode = leftMaxNode.right;

                                    curNode.val = leftMaxNode.val;
                                    if (leftMaxNode.left != null)
                                    {
                                        leftMaxNode.left.parent = leftMaxNode.parent;
                                        leftMaxNode.parent.right = leftMaxNode.left;
                                    }
                                    else
                                        leftMaxNode.parent.right = null;
                                    
                                }
                                else
                                {
                                    curNode.left.parent = curNode.parent;

                                    if (curNode.parent.left == curNode)                                    
                                        curNode.parent.left = curNode.left;
                                    else
                                        curNode.parent.right = curNode.left;
                                }
                            }
                            else
                            {
                                if ( curNode.right != null )
                                {
                                    curNode.right.parent = curNode.parent;
                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = curNode.right;
                                    else
                                        curNode.parent.right = curNode.right;
                                }
                                else
                                {
                                    if (curNode.parent.left == curNode)
                                        curNode.parent.left = null;
                                    else
                                        curNode.parent.right = null;                                            
                                }
                            }
                            break;
                        }
                        else if ( curNode.val > _val)
                        {
                            if (curNode.left == null)
                            {
                                Console.WriteLine(_val + " is not BST!!!");
                                break;
                            }
                            else
                                curNode = curNode.left;
                        }
                        else
                        {
                            if (curNode.right == null)
                            {
                                Console.WriteLine(_val + " is not BST!!!");
                                break;
                            }
                            else
                                curNode = curNode.right;

                        }

                    }
                }
            }

            public bool Search(int val)
            {
                BSTNode curNode = root;

                if (curNode == null)
                    return false;
                else
                {
                    while ( curNode != null )
                    {
                        if (curNode.val == val)
                            return true;
                        else if (curNode.val > val)
                            curNode = curNode.left;
                        else
                            curNode = curNode.right;
                    }

                    return false;
                }
            }

            void TravelsByIn(BSTNode _root)
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
                Console.WriteLine();
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

            // test heap by link
            HeapByLinked myHeapByLinked = new HeapByLinked();

            myHeapByLinked.Insert(0);
            myHeapByLinked.Insert(1);
            myHeapByLinked.Insert(2);
            myHeapByLinked.Insert(3);
            myHeapByLinked.Insert(4);
            myHeapByLinked.Insert(5);
            myHeapByLinked.Insert(6);


            myHeapByLinked.TravelsByPre();
            Console.WriteLine();

            Console.WriteLine(myHeapByLinked.Delete());
            myHeapByLinked.TravelsByPre();
            Console.WriteLine();

            // test heap by array
            HeapByArray myHeapByArray = new HeapByArray();

            myHeapByArray.Insert(0);
            myHeapByArray.Insert(1);
            myHeapByArray.Insert(2);
            myHeapByArray.Insert(3);
            myHeapByArray.Insert(4);
            myHeapByArray.Insert(5);
            myHeapByArray.Insert(6);

            myHeapByArray.Print();

            Console.WriteLine(myHeapByArray.Delete());
            myHeapByArray.Print();

            //Binary Search Tree
            Console.WriteLine("-----------------");
            Console.WriteLine("It's BST Test!!!");
            BST myBST = new BST();

            myBST.Insert(50);
            myBST.Insert(20);
            myBST.Insert(70);
            myBST.Insert(30);
            myBST.Insert(10);
            myBST.Insert(60);
            myBST.Insert(80);
            myBST.Insert(5);
            myBST.Insert(15);
            myBST.Insert(25);
            myBST.Insert(35);
            myBST.Insert(55);
            myBST.Insert(65);
            myBST.Insert(75);
            myBST.Insert(85);
            myBST.Insert(90);
            myBST.Insert(3);
            myBST.Insert(8);

            myBST.TravelsByIn();
            Console.WriteLine(myBST.Search(4));
            Console.WriteLine(myBST.Search(5));

            myBST.Delete(8);
            myBST.TravelsByIn();

            myBST.Delete(20);
            myBST.TravelsByIn();

            myBST.Delete(4);
            myBST.TravelsByIn();

            //Binary Search Tree derived by Binary Tree
            Console.WriteLine("-----------------");
            Console.WriteLine("It's BST Test!!!");
            BSTDerivedBT myBSTDerived = new BSTDerivedBT();

            myBSTDerived.Insert(50);
            myBSTDerived.Insert(20);
            myBSTDerived.Insert(70);
            myBSTDerived.Insert(30);
            myBSTDerived.Insert(10);
            myBSTDerived.Insert(60);
            myBSTDerived.Insert(80);
            myBSTDerived.Insert(5);
            myBSTDerived.Insert(15);
            myBSTDerived.Insert(25);
            myBSTDerived.Insert(35);
            myBSTDerived.Insert(55);
            myBSTDerived.Insert(65);
            myBSTDerived.Insert(75);
            myBSTDerived.Insert(85);
            myBSTDerived.Insert(90);
            myBSTDerived.Insert(3);
            myBSTDerived.Insert(8);

            myBSTDerived.TravelsByIn();
            Console.WriteLine(myBSTDerived.Search(4));
            Console.WriteLine(myBSTDerived.Search(5));

            myBSTDerived.Delete(8);
            myBSTDerived.TravelsByIn();

            myBSTDerived.Delete(20);
            myBSTDerived.TravelsByIn();

            myBSTDerived.Delete(4);
            myBSTDerived.TravelsByIn();






        }
    }
}
