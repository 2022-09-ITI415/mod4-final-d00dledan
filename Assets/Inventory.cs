using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool[] Keys = new bool[3];

     void Start()
    {
        Keys[0] = true;
        Keys[1] = false;
        Keys[2] = false;
        
    }
    
}
