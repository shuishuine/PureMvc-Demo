using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataModel : MonoBehaviour
{
    public string Name = "’≈Œ¿–«";
    public float Blood;
    public float Magic;
    public float Power;

    public PlayerDataModel()
    {
        Blood = 100;
        Magic = 10;
        Power = 100;
    }
}
