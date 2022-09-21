using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject gearPrefab;
    public GearData gearData;
    public Vector3 initialPosition;
    public Vector3 endPosition;
    public float frequency;

    void Awake()
    {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        while (true)
        {
            GameObject clone = Instantiate(gearPrefab, new Vector3(Random.Range(initialPosition.x, endPosition.x),
            Random.Range(initialPosition.y, endPosition.y)),
            Quaternion.identity);
            Gear gear = clone.GetComponent<Gear>();
            gear.Speed = gearData.speed;
            gear.Score = gearData.score;
            yield return new WaitForSeconds(frequency);
        }
    }
}
