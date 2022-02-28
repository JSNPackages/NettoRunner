using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScene : MonoBehaviour {
    public Text finishTimeText;
    
    void Start() {
        this.finishTimeText.text = PlayerPrefs.GetString("finishTime", "Fejl!");
    }

    public void RedirectToMainMenu() {
        SceneManager.LoadScene("Menu");
    }
}
