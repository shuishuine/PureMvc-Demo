using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass 
{
    public TestClass()
    {
        Debug.Log("无参构造");
    }

    public TestClass(int i)
    {
        Debug.Log("int构造" + i);
    }

    public TestClass(string i)
    {
        Debug.Log("string构造" + i);
    }

    public TestClass(int i, string t)
    {
        Debug.Log("int和string构造" + i + t);
    }

    public void Show()
    {
        Debug.Log("无参Show");
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
        Debug.Log("静态Show  " + a + b);
    }
}
