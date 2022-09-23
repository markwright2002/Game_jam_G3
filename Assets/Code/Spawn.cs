using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject gearPrefab;
    public GameObject bombPrefab;
    private GameObject clone;
    public GearData gearData;
    public Vector3 initialPosition;
    public Vector3 endPosition;
    public float frequency;
    public float bombChance;
    private float x;

    void Awake()
    {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        while (true)
        {
            x = Random.Range(0, 100);
            if (x <= bombChance)
            {
                clone = Instantiate(bombPrefab, new Vector3(Random.Range(initialPosition.x, endPosition.x),
                Random.Range(initialPosition.y, endPosition.y)),
                Quaternion.identity);
            }
            else
            {
                clone = Instantiate(gearPrefab, new Vector3(Random.Range(initialPosition.x, endPosition.x),
                Random.Range(initialPosition.y, endPosition.y)),
                Quaternion.identity);
            }
            Gear gear = clone.GetComponent<Gear>();
            gear.Speed = gearData.speed;
            
            if (x <= bombChance)
            {
                gear.Score = -gearData.score;
            }
            else
            {
                gear.Score = gearData.score;
            }
                yield return new WaitForSeconds(frequency);
        }
    }
}
