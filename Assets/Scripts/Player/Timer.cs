using System;
using System.Diagnostics;
using UnityEngine;

public class Timer : MonoBehaviour {
    private Stopwatch stopwatch = new Stopwatch();
    
    public void StartTime() {
        this.stopwatch.Start();
    }

    public TimeSpan StopTime() {
        this.stopwatch.Stop();
        return this.stopwatch.Elapsed;
    }
}
