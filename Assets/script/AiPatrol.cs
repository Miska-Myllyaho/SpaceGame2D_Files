using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPatrol : MonoBehaviour
{
    public float walkSpeed;

    [HideInInspector]
    public bool mustPatrol;

    private bool mustTurn;
    public Rigidbody2D rb;
    public Collider2D bodyCollider;
    public LayerMask wallLayer;
    public LayerMask monsterLayer;
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (mustPatrol)
        {
            Patrol();
        }
    }
   
    void Patrol()
    {
        if (mustTurn || bodyCollider.IsTouchingLayers(wallLayer) || bodyCollider.IsTouchingLayers(monsterLayer))
        {
            Flip();
        }
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }
}
