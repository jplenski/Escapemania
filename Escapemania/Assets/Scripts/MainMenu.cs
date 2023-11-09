using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelOne;
    public string howToPlay;
    public string about;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(levelOne);
    }

    public void OpenHowtoPlay()
    {
        SceneManager.LoadScene(howToPlay);
    }

    public void OpenAbout()
    {
        SceneManager.LoadScene(about);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
