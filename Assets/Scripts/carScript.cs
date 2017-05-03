
using UnityEngine;

public class carScript : MonoBehaviour
{

    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    public GameObject Car;
    public Rigidbody2D rb;
    float speed = 1f;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }


    public void FixedUpdate()
    {
        Destroy(Car, 5);
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

} 
