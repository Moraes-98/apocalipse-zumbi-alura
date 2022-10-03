using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator animator;
    Controlls controlls;

    float magnitude;


    void Start()
    {
        animator = GetComponent<Animator>();
        controlls = GetComponent<Controlls>();
    }


    public void GetAnimationWalk()
    {
        magnitude = new Vector2(controlls.directionX, controlls.directionZ).magnitude;
        animator.SetFloat("magnitude", magnitude);
    }
}
