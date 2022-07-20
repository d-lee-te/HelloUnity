using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameEndBool = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()  {
        if (!gameEndBool)    {
            gameEndBool = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()  {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
