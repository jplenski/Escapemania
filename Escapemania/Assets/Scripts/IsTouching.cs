using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouching : MonoBehaviour
{
  public bool touching;
  public GameObject correctObject;
  // Start is called before the first frame update
  void Start()
  {
    touching = false;
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnCollisionStay(Collision other)
  {
    if(other.gameObject.name == correctObject.gameObject.name)
    {
      touching = true;
    }
  }

  void OnCollisionExit(Collision other)
  {
    touching = false;
  }
}
