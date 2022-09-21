using UnityEngine;

public class Car : MonoBehaviour
{
    public int health;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health -= 1;
        Destroy(collision.gameObject);
    }
}
