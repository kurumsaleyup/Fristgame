using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestardDelay = 4f;


    public GameObject CompleteLevelUI;
    public void EndGame() {

        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game has ended!");
            Invoke("Restart", RestardDelay);
        }

    }

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        Debug.Log("Level Complete!");   

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
