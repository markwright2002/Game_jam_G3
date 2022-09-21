using UnityEngine;

public class Bucket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Gear gear = collision.GetComponent<Gear>();
        EventManager.InvokeOnScore(gear.Score);
        Destroy(gear.gameObject);
    }
}
