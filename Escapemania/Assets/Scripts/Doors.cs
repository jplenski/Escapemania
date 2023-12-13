using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
  public List<IsTouching> doors;
  public GameObject door1;
  public bool door1Unlocked;
  public GameObject key1;
  public GameObject door2;
  public GameObject key2;
  public bool door2Unlocked;
  public GameObject barricade;
  public GameObject crowbar;
  public GameObject winScreen;
  public AudioSource unlockSound;
  public AudioSource winSound;
  public AudioSource music;
  // Start is called before the first frame update
  void Start()
  {
    door1.SetActive(true);
    door1Unlocked = false;
    winScreen.SetActive(false);
    door2.SetActive(true);
    door2Unlocked = false;
    barricade.SetActive(true);
  }

  // Update is called once per frame
  void Update()
  {
    if (doors[0].touching && !door1Unlocked)
    {
      door1Unlocked = true;
      unlockSound.Play();
      door1.SetActive(false);
      key1.SetActive(false);
    }
    if (doors[1].touching && !door2Unlocked)
    {
      door2Unlocked = true;
      door2.SetActive(false);
      key2.SetActive(false);
      winSound.Play();
      music.Stop();
      Time.timeScale = 0f;
      Cursor.lockState = CursorLockMode.None;
      winScreen.SetActive(true);
    }
    if (doors[2].touching)
    {
      barricade.SetActive(false);
      crowbar.SetActive(false);
    }
  }
}
