using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemDataModel
{
    public System.DateTime SystemTimeNow { get; set; } //��ǰϵͳʱ��

    public SystemDataModel()
    {
        SystemTimeNow = System.DateTime.Now;
    }
}
