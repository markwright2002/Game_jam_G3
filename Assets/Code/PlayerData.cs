using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    private int baseTotalScore = 0;
    public int totalScore;
    public int lifes = 3;

    private void OnEnable()
    {
        totalScore = baseTotalScore;
    }
}
