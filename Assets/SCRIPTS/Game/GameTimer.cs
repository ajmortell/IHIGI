using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    private float minutes;
    private float seconds;
    public float timeStart;
    public bool stop = true;
    public bool isTimerActive = false;

    public void startTimer(float from) {
        stop = false;
        timeStart = from;

        Update();
        StartCoroutine(updateCoroutine());
    }

    public void stopTimer()
    {
        stop = true;
        minutes = 0.0f;
        seconds = 0.0f;
        print("STOPPING");
    }

    void Update()
    {
        if (stop) {
            print("TIMER STOPED");
            isTimerActive = false;
            return;
        } else {
            print("TIMER ACTIVE");
            isTimerActive = true;
            timeStart -= Time.deltaTime;
            minutes = Mathf.Floor(timeStart / 60);
            seconds = timeStart % 60;
            if (seconds > 59) { seconds = 59; }
            if (minutes < 0.0f) { stopTimer(); }
            if (timeStart < 0.0f) { timeStart = 0.0f; }
        }
        
    }

    private IEnumerator updateCoroutine()
    {
        while (!stop)
        {
            yield return new WaitForSeconds(0.2f);
        }
    }
}
