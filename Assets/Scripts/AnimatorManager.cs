using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    private Animator animator;
    public bool fireBool;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("Fire", false);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            animator.SetBool("Fire", true);
        }
           
    }
}
