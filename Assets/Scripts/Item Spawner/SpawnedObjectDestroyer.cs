using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObjectDestroyer : MonoBehaviour {





    void OnCollisionEnter2D(Collision2D collision) {
        //Check collision name
        Debug.Log("collision name = " + collision.gameObject.name);
        if (collision.gameObject.name == "Enemy") {
            Destroy(collision.gameObject);
        }
    }
}