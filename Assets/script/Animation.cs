using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private float horizontal;
    private Rigidbody2D rb;
    private Animator anim;
    private float attackTime = 0.25f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(horizontal) > 0 && rb.velocity.y == 0)
            anim.SetBool("isRunning", true);
        else
            anim.SetBool("isRunning", false);

        if (rb.velocity.y == 0)
        {
            anim.SetBool("isJumpping", false);
            anim.SetBool("isFalling", false);
        }
        if (rb.velocity.y > 0)
           anim.SetBool("isJumpping", true) ;

        if (rb.velocity.y < 0) 
        {
            anim.SetBool("isJumpping", false);
            anim.SetBool("isFalling", true);
        }
       if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isAttacking", true);
            StartCoroutine(AttackTime());
        }
         IEnumerator AttackTime()
        {
            yield return new WaitForSeconds(attackTime);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isPunching", false);
        }
       if (Input.GetKeyUp(KeyCode.W) && Mathf.Abs(horizontal) > 0 && rb.velocity.y == 0)
        {
            anim.SetBool("isPunching", true);
            StartCoroutine(AttackTime());
        }
    }
}
   

