using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   

        if(Input.GetKeyDown(KeyCode.Mouse0)  || Input.GetButton("Fire3"))
        {
            animator.SetTrigger("PunchTrigger");
           
        }
       
    }
}
