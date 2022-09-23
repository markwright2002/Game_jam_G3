using UnityEngine;

public class Gear : MonoBehaviour
{
    public float Speed { get; set; }
    public int Score { get; set; }
    public bool isHorizontal = false;
    private float x;

    void Start()
    {

        x = 0;

    }

    void Update()
    {
        x += Time.deltaTime;
        if (x > 5)
        {
            Destroy(gameObject);
        }
        if (isHorizontal)
        {
            transform.position += new Vector3(
                            Speed * Time.deltaTime,
                            0,
                            0
                            );

        }
        else
        {
            transform.position += new Vector3(
                0,
                Speed * Time.deltaTime,
                0
                );
        }
    }
}
