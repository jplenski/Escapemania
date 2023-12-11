using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
  public List<IsTouching> trays;
  public GameObject lid;
  public bool completed;
  public AudioSource completeSound;
  // Start is called before the first frame update
  void Start()
  {
    completed = false;
    lid.SetActive(true);
  }

  // Update is called once per frame
  void Update()
  {
    // Add Thumbs up animation here?
    if (!completed)
    {
      if (trays[0].touching && trays[1].touching && trays[2].touching && trays[3].touching)
      {
        completed = true;
        completeSound.Play();
        lid.SetActive(false);
      }
    }
  }
}
