using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass 
{
    public TestClass()
    {
        Debug.Log("�޲ι���");
    }

    public TestClass(int i)
    {
        Debug.Log("int����" + i);
    }

    public TestClass(string i)
    {
        Debug.Log("string����" + i);
    }

    public TestClass(int i, string t)
    {
        Debug.Log("int��string����" + i + t);
    }

    public void Show()
    {
        Debug.Log("�޲�Show");
    }

    public void Show(int a)
    {
        Debug.Log("Show  " + a);
    }

    public  void Show(int a,string b)
    {
        Debug.Log("IntString  " + a + b);
    }

    public static void Show(int a,int b)
    {
        Debug.Log("��̬Show  " + a + b);
    }
}
