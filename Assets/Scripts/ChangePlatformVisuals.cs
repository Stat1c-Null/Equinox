using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlatformVisuals : MonoBehaviour
{
    Animator animator;
    public RuntimeAnimatorController nightAnimator;
    public RuntimeAnimatorController dayAnimator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.isDay) {
            animator.runtimeAnimatorController = dayAnimator;
        } else {
            animator.runtimeAnimatorController = nightAnimator;
        }


    }
}
