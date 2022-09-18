using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVars : MonoBehaviour
{

    public static int engP, tireP, bodyP, HP;
    public static float spd;
    void awake()
    {
        engP = 0;
        tireP = 0;
        bodyP = 0;
        HP = 3;


    }
}