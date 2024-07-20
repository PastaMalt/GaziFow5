using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("Holding");
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
           animator.SetTrigger("Fire");
        }
    }
}
