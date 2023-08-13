using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandRun : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);

        }

        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);

        }
    }


    void Update()
    {

    }
}
