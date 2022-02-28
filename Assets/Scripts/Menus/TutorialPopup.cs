using UnityEngine;

public class TutorialPopup : MonoBehaviour {
    public GameObject[] menuObjects;
    public GameObject player;

    void Start() {
        Time.timeScale = 0f;
    }

    public void hideMenu() {
        foreach (GameObject g in this.menuObjects) {
            Destroy(g);
        }

        Time.timeScale = 1f;
        this.player.GetComponent<Timer>().StartTime();
    }
}
