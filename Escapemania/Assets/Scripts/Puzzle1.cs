using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
  public List<IsTouching> trays;
  public GameObject key;
  public bool allCorrect;
  public int sum;
  // Start is called before the first frame update
  void Start()
  {
    key.SetActive(false);
    allCorrect = false;
    sum = 0;
  }

  // Update is called once per frame
  void Update()
  {
    if (trays[0].touching && trays[1].touching && trays[2].touching && trays[3].touching)
    {
      key.SetActive(true);
    }
  }
}
