using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
  public List<InRange> notes;
  public GameObject note1;
  public bool reading;
  // Start is called before the first frame update
  void Start()
  {
    reading = false;
    note1.SetActive(false);  
  }

  // Update is called once per frame
  void Update()
  {
    foreach (InRange note in notes)
    {
      if (note.inRange && !reading && Input.GetButtonDown("read"))
      {
        reading = true;
        note.display.SetActive(true);
      }
      if (!note.inRange)
      {
        reading = false;
        note.display.SetActive(false);
      }
    } 
  }
}
