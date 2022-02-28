using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eMove : MonoBehaviour {

    public float speed = 10.0f;
    private Rigidbody2D bullet;

    // Start is called before the first frame update
    void Start() {
        bullet = this.GetComponent<Rigidbody2D>();
        bullet.velocity = Vector2.left * speed;


    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            collision.gameObject.GetComponent<RespawnPlayer>().RespawnMyPlayer();
        }
    }
}