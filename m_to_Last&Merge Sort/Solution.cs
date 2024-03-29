﻿using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int output;
        string readLine = Console.ReadLine();
        int[] a = Array.ConvertAll(readLine.Split(' '), temp => Convert.ToInt32(temp));

        //    int[] a = Array.ConvertAll(Console.ReadLine().Split(" "), atemp => Convert.ToInt32(atemp));

        //     mergeSort(a, 0,a.Length - 1);
        if (n > a.Length)
        {
            Console.WriteLine("NIL");

        }
        else
        {
            output = a[a.Length - n];
            Console.Out.WriteLine("{0}", output);
        }

    }
    static public void mergeSort(int[] arr, int p, int r)
    {
        if (p < r)
        {
            int q = (p + r) / 2;
            mergeSort(arr, p, q);
            mergeSort(arr, q + 1, r);
            merge(arr, p, q, r);
        }
    }
    static public void merge(int[] arr, int p, int q, int r)
    {
        int i, j, k;
        int n1 = q - p + 1;
        int n2 = r - q;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for (i = 0; i < n1; i++)
        {
            L[i] = arr[p + i];
        }
        for (j = 0; j < n2; j++)
        {
            R[j] = arr[q + 1 + j];
        }
        i = 0;
        j = 0;
        k = p;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}
