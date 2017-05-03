using UnityEngine.SceneManagement;
using UnityEngine;

public class Frog : MonoBehaviour {
    public Rigidbody2D rb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        Vector2 posUp = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -4.5f, 5f));
        transform.position = posUp;
    }
     void OnTriggerEnter2D (Collider2D col)
        {
            if (col.tag == "Car")
            {
                Debug.Log("VI LOST ZULUL");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
      }
    
}
