using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour {

    public GameObject navigationPanel;
    public GameObject rightBtnObject;
    public GameObject leftBtnObject;
    public GameObject doorBtnObject;
    public GameObject doorOpenPanel;

    private float speed = 40.0f;

    bool movingLeft;
    bool movingRight;

    void Awake() {
        rightBtnObject.SetActive(false);
        movingLeft = false;
        movingRight = false;
        doorOpenPanel.SetActive(false);
    }

    IEnumerator left() {
        leftBtnObject.SetActive(false);
        moveDirection("left");  
        yield return new WaitForSeconds(4.0f);   
        rightBtnObject.SetActive(true);
    }

    IEnumerator right() {
        rightBtnObject.SetActive(false);
        moveDirection("right");
        yield return new WaitForSeconds(4.0f);
        leftBtnObject.SetActive(true);  
    }

    IEnumerator exit() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }

    public void OnLeftBtnPress() {
        StartCoroutine(left());     
    }

    public void OnRightBtnPress() {
        StartCoroutine(right());
    }
    
    public void OnDoorBtnClicked() {
        doorOpenPanel.SetActive(true);
        StartCoroutine(exit());
    }

    public void moveDirection(string direction) {

        Vector3 offset;
        offset = Vector3.zero;

        switch (direction) {
            case "left":            
                movingLeft = true;
                break;

            case "right":             
                movingRight = true;
                break;
        }
    }

    void LateUpdate() {
      
        if (movingLeft == true) {
            float step = speed * Time.deltaTime;
            navigationPanel.transform.position = Vector3.MoveTowards(navigationPanel.transform.position, new Vector3(0, 0, 0), step);

            if (navigationPanel.transform.position == new Vector3(0,0,0)) {             
                movingLeft = false;
                
            }
        }

        if (movingRight == true & movingLeft != true) {
            float step = speed * Time.deltaTime;
            navigationPanel.transform.position = Vector3.MoveTowards(navigationPanel.transform.position, new Vector3(128, 0, 0), step);

            if (navigationPanel.transform.position == new Vector3(128, 0, 0)) {
                movingRight = false;
            }
        }
            
    }
}
