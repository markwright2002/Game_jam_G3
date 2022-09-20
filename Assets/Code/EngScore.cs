using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EngScore : MonoBehaviour
{
    // Start is called before the first frame update
    public float Score;
    public TextMeshProUGUI TMP;
    void Start()
    {
        Score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = globalVars.engP;
        TMP.text = Score.ToString();
    }
}
