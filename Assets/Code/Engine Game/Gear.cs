using UnityEngine;

public class Gear : MonoBehaviour
{
    public float Speed { get; set; }
    public int Score { get; set; }
    void Update()
    {
        transform.position += new Vector3(
            0,
            Speed * Time.deltaTime,
            0
            );
    }
}
