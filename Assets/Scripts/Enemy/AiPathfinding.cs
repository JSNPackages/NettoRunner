using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPathfinding : MonoBehaviour
{

    public float Walkspeed;

    [HideInInspector]
    public bool mustPatrol;

    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol) {
            Patrol();
        }
        void Patrol() {
            rb.velocity = new Vector2(Walkspeed * Time.deltaTime, rb.velocity.y);
        }

        void Flip() {
            mustPatrol = false;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            Walkspeed *= -1;
            mustPatrol = true;
        }
    }
}
