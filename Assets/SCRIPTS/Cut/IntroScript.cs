using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour {

    public bool displayImage = false;
    public bool displayMessage = false;
    public string messageString;
    public string image;
    public float timerStart;

    private GameTimer gameTimer;

    void Awake() {
        gameTimer = GetComponent<GameTimer>();
    }

    private void Start() {
        gameTimer.startTimer(timerStart);
    }

}
