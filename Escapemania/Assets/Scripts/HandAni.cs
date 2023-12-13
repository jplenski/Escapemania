using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAni : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("Hand Up", true);
        }
        else
        {
            animator.SetBool("Hand Up", false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("Thumbs Up", true);
            
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("Thumbs Up", false);
        }
    }
}
