using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
  public Vector3 offset;
  public float mouseZCoordinate;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
        
  }
    
  void OnMouseDown()
  {
    mouseZCoordinate = Camera.main.WorldToScreenPoint(transform.position).z;
    offset = transform.position - GetMouseWorldPos();
  }

  Vector3 GetMouseWorldPos()
  {
    Vector3 pos = Input.mousePosition;
    pos.z = mouseZCoordinate;
    return Camera.main.ScreenToWorldPoint(pos);
  }

  void OnMouseDrag()
  {
    transform.position = GetMouseWorldPos() + offset;
  }
}
