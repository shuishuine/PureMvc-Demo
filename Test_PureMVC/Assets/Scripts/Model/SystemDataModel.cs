using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemDataModel
{
    public System.DateTime SystemTimeNow { get; set; } //当前系统时间

    public SystemDataModel()
    {
        SystemTimeNow = System.DateTime.Now;
    }
}
