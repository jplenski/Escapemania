using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
  public List<IsTouching> doors;
  public GameObject door1;
  public GameObject key1;
  public GameObject winScreen;
  // Start is called before the first frame update
  void Start()
  {
    door1.SetActive(true);
    winScreen.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
    if (doors[0].touching)
    {
      door1.SetActive(false);
      key1.SetActive(false);
      winScreen.SetActive(true);
      Time.timeScale = 0f;
      Cursor.lockState = CursorLockMode.None;
    }
  }
}
