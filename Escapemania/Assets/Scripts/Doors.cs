using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
  public List<IsTouching> doors;
  public GameObject door1;
  public GameObject key1;
  public GameObject door2;
  public GameObject key2;
  public GameObject winScreen;
  // Start is called before the first frame update
  void Start()
  {
    door1.SetActive(true);
    winScreen.SetActive(false);
    door2.SetActive(true);
  }

  // Update is called once per frame
  void Update()
  {
    if (doors[0].touching)
    {
      door1.SetActive(false);
      key1.SetActive(false);
    }
    if (doors[1].touching)
    {
      door2.SetActive(false);
      key2.SetActive(false);
      Time.timeScale = 0f;
      Cursor.lockState = CursorLockMode.None;
      winScreen.SetActive(true);
    }
  }
}
