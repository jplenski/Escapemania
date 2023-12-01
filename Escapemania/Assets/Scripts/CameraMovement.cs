using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
  public float sensitivity = 0.5f;
  public Transform camera;
  float xRotation = 0f;

  // Start is called before the first frame update
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = true;
  }

  // Update is called once per frame
  void Update()
  {
    // Get mouse input
    float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
    float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
    xRotation -= y;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    camera.Rotate(Vector3.up * x);
  }
}
