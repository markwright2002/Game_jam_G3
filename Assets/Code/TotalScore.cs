using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore : MonoBehaviour
{

    public TextMeshProUGUI TMP;
    public PlayerData data;
    // Start is called before the first frame update
    void Start()
    {
        TMP.text = data.totalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
