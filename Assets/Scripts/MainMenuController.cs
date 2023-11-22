
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    public Slider slider;
    private int volume;
    public GameObject mainPannel;
    public GameObject levelsPannel;
    public GameObject optionsPannel;

    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.HasKey("volume"))
        {
            volume= PlayerPrefs.GetInt("volume");
            slider.value = volume;
        }
        else
        {
            volume = 100;
            PlayerPrefs.SetInt("volume", volume);
            PlayerPrefs.Save();
            slider.value = volume;
        }
        mainPannel.SetActive(true); ;
        optionsPannel.SetActive(false);
        levelsPannel.SetActive(false);
        
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
        


    }




    public void Play()
    {
        mainPannel.SetActive(false); ;
        optionsPannel.SetActive(false);
        levelsPannel.SetActive(true);
    }
    public void BackToMainMenu()
    {
        mainPannel.SetActive(true); ;
        optionsPannel.SetActive(false);
        levelsPannel.SetActive(false);
    }
    public void Options()
    {
        mainPannel.SetActive(false);
        optionsPannel.SetActive(true);

    }

    public void Back()
    {
        mainPannel.SetActive(true);
        optionsPannel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
