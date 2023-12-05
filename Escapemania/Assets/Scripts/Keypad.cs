using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
  public InRange keypad;
  public GameObject keypadScreen;
  public bool interacting;
  public CameraMovement camera;
  public TextMeshProUGUI codeText;
  public List<GameObject> buttons;
  public GameObject lid2;
  public AudioSource correctSound;
  public AudioSource wrongSound;
  // Start is called before the first frame update
  void Start()
  {
    interacting = false;
    keypadScreen.SetActive(false);
    codeText.text = "";
    lid2.SetActive(true);
  }

  // Update is called once per frame
  void Update()
  {
    if (keypad.inRange && interacting)
    {
      Cursor.lockState = CursorLockMode.None;
      camera.enabled = false;
    }
    if (keypad.inRange && !interacting && Input.GetButtonDown("read"))
    {
      interacting = true;
      camera.enabled = false;
      Cursor.lockState = CursorLockMode.None;
      keypad.display.SetActive(true);
    }
    else if (!keypad.inRange && interacting)
    {
      interacting = false;
      camera.enabled = true;
      Cursor.lockState = CursorLockMode.Locked;
      keypad.display.SetActive(false);
    }
    else if (keypad.inRange && interacting && Input.GetButtonDown("read"))
    {
      interacting = false;
      camera.enabled = true;
      Cursor.lockState = CursorLockMode.Locked;
      keypad.display.SetActive(false);
    }
  }

  public void TypeCodeOne()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "1";
    }
  }

  public void TypeCodeTwo()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "2";
    }
  }

  public void TypeCodeThree()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "3";
    }
  }

  public void TypeCodeFour()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "4";
    }
  }

  public void TypeCodeFive()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "5";
    }
  }

  public void TypeCodeSix()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "6";
    }
  }

  public void TypeCodeSeven()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "7";
    }
  }

  public void TypeCodeEight()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "8";
    }
  }

  public void TypeCodeNine()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "9";
    }
  }

  public void TypeCodeZero()
  {
    if (codeText.text.Length < 4)
    {
      codeText.text = codeText.text + "0";
    }
  }

    public void EnterCode()
  {
    if (codeText.text == "2938")
    {
      correctSound.Play();
      lid2.SetActive(false);
      keypadScreen.SetActive(false);
      interacting = false;
      camera.enabled = true;
      Cursor.lockState = CursorLockMode.Locked;
      this.enabled = false;
    }
    else
    {
      wrongSound.Play();
      codeText.text = "";
    }
  }

  public void Backspace()
  {
    if (codeText.text.Length > 0)
    {
      codeText.text = codeText.text.Remove(codeText.text.Length - 1);
    }
  }
}
