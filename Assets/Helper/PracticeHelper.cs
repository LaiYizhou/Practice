﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TreeNode
{
    public int value;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val)
    {
        this.value = val;
        left = null;
        right = null;
    }

}


public class ListDoubleNode
{
    public int value;
    public ListDoubleNode pre;
    public ListDoubleNode next;

    public ListDoubleNode(int val)
    {
        value = val;
        pre = null;
        next = null;
    }

}

public class ListNode
{
    public int value;
    public ListNode next;

    public ListNode(int val)
    {
        this.value = val;
        next = null;
    }
}

public static class PracticeHelper
{
    public static ListNode ToCircleListNode(this List<int> list)
    {
        ListNode node = null;

        if (list.Count == 0)
        {
            return node;
        }

        List<ListNode> nodeList = new List<ListNode>();
        for (int i = 0; i < list.Count; i++)
        {
            ListNode temp = new ListNode(list[i]);
            nodeList.Add(temp);
        }

        for (int i = 0; i < nodeList.Count - 1; i++)
        {
            nodeList[i].next = nodeList[i + 1];
        }

        node = nodeList[0];

        nodeList[nodeList.Count - 1].next = nodeList[0];
        return node;

    }

    public static ListNode ToListNode(this List<int> list)
    {
        ListNode node = null;

        if (list.Count == 0)
        {
            return node;
        }

        List<ListNode> nodeList = new List<ListNode>();
        for (int i = 0; i < list.Count; i++)
        {
            ListNode temp = new ListNode(list[i]);
            nodeList.Add(temp);
        }

        for (int i = 0; i < nodeList.Count - 1; i++)
        {
            nodeList[i].next = nodeList[i + 1];
        }

        node = nodeList[0];
        return node;
    }

    public static void Print(this ListNode node)
    {
        StringBuilder sb = new StringBuilder();

        ListNode temp = node;

        if (node == null)
        {
            Debug.Log(node);
            return;
        }

        while (node != null)
        {
            sb.Append(node.value).Append("->");
            node = node.next;

            if (node == temp)
            {
                sb.Append(string.Format("({0})", temp.value));
                Debug.Log(sb);
                return;
            }

        }

        sb.Append("Null");

        Debug.Log(sb);

    }

    public static void Print<T1, T2>(this Dictionary<T1, T2> dictionary)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var pair in dictionary)
        {
            sb.Append(pair.Key.ToString()).Append(" : ").Append(pair.Value.ToString()).Append(Environment.NewLine);
        }

        Debug.Log(sb.ToString());
    }

    public static void Print<T>(this T[][] array)
    {
        int length = array.Length;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            int curMax = array[i].Length;
            int j = 0;
            for (; j < curMax - 1; j++)
            {
                sb.Append(array[i][j].ToString()).Append(",");
            }

            sb.Append(array[i][j].ToString()).Append(System.Environment.NewLine);
        }

        Debug.Log(sb.ToString());

    }

    public static void Print<T>(this T[,] array)
    {
        int row = array.GetLength(0);
        int col = array.GetLength(1);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < row; i++)
        {
            int j = 0;
            for (j = 0; j < col - 1; j++)
            {
                sb.Append(array[i, j].ToString()).Append(",");

            }

            sb.Append(array[i, j].ToString()).Append(System.Environment.NewLine);
        }

        Debug.Log(sb.ToString());

    }

    public static void Shuffle<T>(this List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int index = UnityEngine.Random.Range(0, i);

            T temp = list[index];
            list[index] = list[i];
            list[i] = temp;

        }
    }

    public static void Print<T>(this List<T> list)
    {
        StringBuilder sb = new StringBuilder();

        int i = 0;
        for (; i < list.Count - 1; i++)
        {
            sb.Append(list[i].ToString()).Append(",");
        }

        sb.Append(list[i].ToString());

        Debug.Log(sb.ToString());

    }

    public static void Print<T>(this T[] array)
    {
        StringBuilder sb = new StringBuilder();

        if (array[0] is char)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i].ToString());
            }

        }
        else
        {
            int i = 0;
            for (; i < array.Length - 1; i++)
            {
                sb.Append(array[i].ToString()).Append(",");
            }

            sb.Append(array[i].ToString());
        }

        Debug.Log(sb.ToString());

    }
}
