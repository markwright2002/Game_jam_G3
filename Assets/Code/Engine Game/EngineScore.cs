using UnityEngine;
using TMPro;


public class EngineScore : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI TMP;
    public PlayerData data;
    void OnEnable()
    {
        score = 0;
        EventManager.OnScore += UpdateScore;
        EventManager.OnMinigameEnd += AssignScore;
    }

    void OnDisable()
    {
        EventManager.OnScore -= UpdateScore;
        EventManager.OnMinigameEnd -= AssignScore;
    }

    public void UpdateScore(int value)
    {
        score += value;
        TMP.text = score.ToString();
    }

    public void AssignScore()
    {
        data.totalScore += score;
    }
}
