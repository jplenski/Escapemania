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

  // Start is called before the first frame update
  void Start()
  {
    Time.timeScale = 1f;
    timerText.text = "";
    timeRemaining = 30;
    loseScreen.SetActive(false);
    timerOn = true;
  }

  // Update is called once per frame
  void Update()
  {
    if (timerOn)
    {
      if (timeRemaining > 0)
      {
        timeRemaining = timeRemaining - Time.deltaTime;
        changeTime(timeRemaining);
      }
      else
      {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
      }
    }
  }

  void changeTime(float timeRemaining)
  {
    float rounded = Mathf.Round(timeRemaining);
    timerText.text = rounded.ToString();
  }
}