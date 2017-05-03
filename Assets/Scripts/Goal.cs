using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Debug.Log("VI VON ZULUL");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
