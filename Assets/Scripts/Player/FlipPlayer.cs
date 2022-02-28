using UnityEngine;

public class FlipPlayer : MonoBehaviour {
    bool facingRight = true;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.A) && this.facingRight) {
            GetComponent<SpriteRenderer>().flipX = this.facingRight;
            this.facingRight = !this.facingRight;
        }
        else if (Input.GetKeyDown(KeyCode.D) && !this.facingRight) {
            GetComponent<SpriteRenderer>().flipX = this.facingRight;
            this.facingRight = !this.facingRight;
        }
    }
}
