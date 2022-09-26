using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TireScore : MonoBehaviour
{
    // Start is called before the first frame update


    public int score;
    public int amount;
    public TextMeshProUGUI TMP;
    public PlayerData data;
    public GameObject wheel;

    void OnEnable()
    {
        score = 0;
        EventManager.OnHit += Increase;
        EventManager.OnMiss += Decrease;
        EventManager.OnMinigameEnd += AssignScore;
    }

    void Start()
    {
        wheel.transform.localScale = new Vector3(0.1f * score, 0.1f * score, 0.1f * score);
    }

    void OnDisable()
    {
        EventManager.OnHit -= Increase;
        EventManager.OnMiss -= Decrease;
        EventManager.OnMinigameEnd -= AssignScore;
    }

    void Increase()
    {
        score += amount;
        TMP.text = score.ToString();

        wheel.transform.localScale = new Vector3(0.1f * score, 0.1f * score, 0.1f * score);
    }

    void Decrease()
    {
        score -= amount;
        TMP.text = score.ToString();
        wheel.transform.localScale = new Vector3(0.1f * score, 0.1f * score, 0.1f * score);
    }
    
    public void AssignScore()
    {
        data.totalScore += score;
    }
}
