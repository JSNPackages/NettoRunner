using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    Vector2 spawnPos;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() {
        spawnPos = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    public void SetSpawnPoint(Vector2 newSpawn) {
        spawnPos = newSpawn;
    }

    public void RespawnMyPlayer() {
        rb.velocity = Vector2.zero;
        transform.position = spawnPos;

    }
}
