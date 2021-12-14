using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Test : MonoBehaviour
{

    private void Start()
    {
        TestClass testClass = new TestClass();

        var type = testClass.GetType();


        var constructor = type.GetConstructor(new Type[] { });
        var constructor1 = type.GetConstructor(new Type[] { typeof(int) });
        var constructor2 = type.GetConstructor(new Type[] { typeof(string) });
        var constructor3 = type.GetConstructor(new Type[] { typeof(int), typeof(string) });

        constructor.Invoke(null);
        constructor1.Invoke(new object[] { 1 });
        constructor2.Invoke(new object[] { "a" });
        constructor3.Invoke(new object[] { 1, "a" });

        BindingFlags f = BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Static;


        /*  var method = type.GetMethod("Show",new Type[] { typeof(int) , typeof(string)});
          method.Invoke(testClass, new object[] { 1 ,"aaa"}); */


        /*var method = type.GetMethod(
            "Show",
            f,
            null,
            CallingConventions.Any,
            new Type[2] { typeof(int), typeof(int) },
            null
            );
        method.Invoke(testClass, new object[] { 1, 2 });*/



        /*//获取所有的方法和构造函数
        var method1 = type.GetMethods();
        foreach (var item in method1)
        {
            Debug.Log(item);
        }*/
    }
}
