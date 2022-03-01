using System;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour {
    private Vector2 spawnPoint;
    private Vector2 currentSpawn;
    Rigidbody2D rb;
    int health = 3;

    // Start is called before the first frame update
    void Start() {
        this.spawnPoint = transform.position;
        this.currentSpawn = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    public void SetSpawnPoint(Vector2 newSpawn) {
        this.currentSpawn = newSpawn;
    }

    public void RespawnMyPlayer() {
        rb.velocity = Vector2.zero;

        if (this.health == 0) {
            this.currentSpawn = this.spawnPoint;
        }
        
        transform.position = this.currentSpawn.normalized;
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Enemy")) {
            this.health -= 1;
            RespawnMyPlayer();
        }
    }
}
