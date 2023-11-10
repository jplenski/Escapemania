using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  public CharacterController controller;
  float movementSpeed = 5f;
  Vector3 originalPosition;
  Vector3 originalScale;
  public bool isCrouched;
  // Start is called before the first frame update
  void Start()
  {
    originalScale = transform.localScale;
    originalPosition = transform.localPosition;
    isCrouched = false;
  }

  // Update is called once per frame
  void Update()
  {
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    Vector3 move = transform.right * x + transform.forward * z;
    controller.Move(move * movementSpeed * Time.deltaTime);
  }
}