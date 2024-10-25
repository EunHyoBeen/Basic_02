using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int AnimationVariable = 0;
    private Animator animator;


    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        animator.SetInteger("State", 0);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        AnimationVariable++;
        if(AnimationVariable > 2)
        {
            AnimationVariable = 0;
        }
        animator.SetInteger("State", AnimationVariable);
        
    }
}
