using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EngTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float x, maxTime;
    public TextMeshProUGUI TMP;
    void Start()
    {
        x = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        TMP.text = (Mathf.Round(x)).ToString();
        x -= Time.deltaTime;
    }
}
