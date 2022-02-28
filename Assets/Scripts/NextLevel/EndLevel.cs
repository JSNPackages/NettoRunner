using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour {
    public Text timerText;
    private void OnTriggerEnter2D(Collider2D collision) {
        TimeSpan stopTime = collision.GetComponent<Timer>().StopTime();
        String timeText = $"{stopTime.Minutes}:{stopTime.Seconds}";
        PlayerPrefs.SetString("finishTime", timeText);
        
        SceneManager.LoadScene("WinScene");
    }
}
