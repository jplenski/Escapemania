using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
  public float timeRemaining;
  public bool timerOn;
  public TextMeshProUGUI timerText;
  [SerializeField] GameObject loseScreen;
  public AudioSource loseSound;
  public bool lost;
  public AudioSource music;

  // Start is called before the first frame update
  void Start()
  {
    Time.timeScale = 1f;
    timerText.text = "";
    timeRemaining = 300;
    loseScreen.SetActive(false);
    timerOn = true;
    lost = false;
  }

  // Update is called once per frame
  void Update()
  {
    if (timerOn)
    {
      if (timeRemaining <= 0 && !lost)
      {
        loseSound.Play();
        Cursor.lockState = CursorLockMode.None;
        music.Stop();
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
        lost = true;
      }
      else
      {
        timeRemaining = timeRemaining - Time.deltaTime;
        changeTime(timeRemaining);
      }
    }
  }

  void changeTime(float timeRemaining)
  {
    float rounded = Mathf.Round(timeRemaining);
    timerText.text = rounded.ToString();
  }
}