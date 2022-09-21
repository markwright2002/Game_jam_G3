using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float leftConstraint, rightConstraint;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(
            horizontal * speed * Time.deltaTime,
            0,
            0);

        if (transform.position.x > rightConstraint)
        {
            Vector3 position = transform.position;
            position.x = rightConstraint;
            transform.position = position;
        }

     

        if (transform.position.x < leftConstraint)
        {
            Vector3 position = transform.position;
            position.x = leftConstraint;
            transform.position = position;
        }
    }

}
