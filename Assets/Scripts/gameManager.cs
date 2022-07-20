using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameEndBool = false;
    public float restartDelay = 1f;

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
