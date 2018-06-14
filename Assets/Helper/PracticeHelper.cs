using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#region 拓展方法

public static class PracticeHelper
{

    public static ListNode ToListNodeWithCircle(this List<int> list, int index)
    {
        ListNode node = null;

        if (list.Count == 0)
        {
            return node;
        }

        if (index > list.Count - 1)
        {
            Debug.LogError("Can't convert to a List with circle ! ! !");
            return null;
        }

        ListNode circleNode = null;

        List<ListNode> nodeList = new List<ListNode>();
        for (int i = 0; i < list.Count; i++)
        {
            ListNode temp = new ListNode(list[i]);
            nodeList.Add(temp);

            if (i == index)
                circleNode = temp;

        }

        for (int i = 0; i < nodeList.Count - 1; i++)
        {
            nodeList[i].next = nodeList[i + 1];
        }

        node = nodeList[0];

        nodeList[nodeList.Count - 1].next = circleNode;

        return node;
    }

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

    public static void Print(this ListRandomNode node)
    {
        StringBuilder sb = new StringBuilder();

        if (node == null)
        {
            Debug.Log(null);
            return;
        }

        while (node != null)
        {
            sb.Append(node.value).Append("(").Append(node.rand == null ? "Null" : node.rand.value.ToString()).Append(")").Append("->");
            node = node.next;
        }

        sb.Append("Null");

        Debug.Log(sb);

    }

    public static void Print(this ListNode node)
    {
        StringBuilder sb = new StringBuilder();

        if (node == null)
        {
            Debug.Log(node);
            return;
        }

        List<ListNode> visitedNodeList = new List<ListNode>();

        while (node != null)
        {
            sb.Append(node.value).Append("->");
            visitedNodeList.Add(node);

            node = node.next;

            if (visitedNodeList.Contains(node))
            {
                sb.Append(string.Format("({0})", node.value));
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

#endregion

#region 数据结构

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

    public override string ToString()
    {
        return value.ToString();
    }
}

public class ListRandomNode
{
    public int value;
    public ListRandomNode next;
    public ListRandomNode rand;

    public ListRandomNode(int val)
    {
        this.value = val;
        next = null;
        rand = null;
    }
}

#endregion
