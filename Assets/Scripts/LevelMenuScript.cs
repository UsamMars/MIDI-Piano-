
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMenuScript : MonoBehaviour
{
    private bool isPaused = false;
    void Start()
    {
        ResumeGame(); // Start with the game unpaused
    }

    public void PauseGame()
    {
        if(isPaused==false)
        {
            isPaused = true;
            Time.timeScale = 0f; // Pause time
            Debug.Log("game paused");
        }
        else
        {
            ResumeGame(); // Start with the game unpaused
        }
        
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume time
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
