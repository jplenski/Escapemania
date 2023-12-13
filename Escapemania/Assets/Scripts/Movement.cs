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
  public float gravity;
  Vector3 vel;
  public Animator animator;
  // Start is called before the first frame update
  void Start()
  {
    gravity = -9.18f;
    originalScale = transform.localScale;
    originalPosition = transform.localPosition;
    isCrouched = false;
    animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    Vector3 move = transform.right * x + transform.forward * z;
    controller.Move(move * movementSpeed * Time.deltaTime);
    if (vel.y > -9.18)
    {
      vel.y += gravity * Time.deltaTime;
    }
    controller.Move(vel * Time.deltaTime);
    // Add check for animation
    
    /*if(move == Vector3.zero)
        {
            animator.SetFloat("Speed", 0);
        }
        else
        {
            animator.SetFloat("Speed", 0.4f);
        }*/
  }
}