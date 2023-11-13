using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
  public GameObject pauseScreen;

  void Start()
  {
    pauseScreen.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Cancel"))
    {
      Cursor.lockState = CursorLockMode.None;
      if (!pauseScreen.activeSelf)
      {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
      }
      else
      {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
      }
    }
  }

  public void Resume()
  {
    Time.timeScale = 1f;
    Cursor.lockState = CursorLockMode.Locked;
    pauseScreen.SetActive(false);
  }

  public void Menu()
  {
    Time.timeScale = 1f;
    SceneManager.LoadSceneAsync(0);
  }
}