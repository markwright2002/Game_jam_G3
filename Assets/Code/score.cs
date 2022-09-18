using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{

    public float Score, x;
    public TextMeshProUGUI TMP;
    // Start is called before the first frame update
    void Start()
    {

        Score = 0;
        x = 0;

    }

    // Update is called once per frame
    void Update()
    {

        

        TMP.text = Score.ToString();
        x += Time.deltaTime;

        if (x > 1){

            Score += (1 * globalVars.spd);
            x -= 1;
        }

    }
}
