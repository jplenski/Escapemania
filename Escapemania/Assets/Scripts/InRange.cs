using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRange : MonoBehaviour
{
  public bool inRange;
  public GameObject display;
  public GameObject notePrompt;
  // Start is called before the first frame update
  void Start()
  {
    display.SetActive(false);
    inRange = false;
    notePrompt.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  void OnTriggerStay(Collider other)
  {
    inRange = true;
    notePrompt.SetActive(true);
  }

  void OnTriggerExit(Collider other)
  {
    inRange = false;
    notePrompt.SetActive(false);
  }
}
