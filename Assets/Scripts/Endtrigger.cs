using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Invoke("InvokeMethod", 4f);
        
    }
    public void InvokeMethod()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
