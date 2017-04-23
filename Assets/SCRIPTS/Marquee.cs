using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marquee : MonoBehaviour {
    /*
    public Texture marqueeTexture;

    private Vector2 marqueeOrigin;
    private Vector2 marqueeSize;

    public Rect marqueeRect;
    public GameObject SelectableArea;

    private void OnGUI() {

        //marqueeRect = new Rect(marqueeOrigin.x, marqueeOrigin.y, marqueeSize.x, marqueeSize.y);
        marqueeRect = new Rect(marqueeOrigin.x, marqueeOrigin.y , 64, 32);
        GUI.color = new Color(8.0f, 0.0f, 255.0f, 0.5f);
        
        GUI.DrawTexture(marqueeRect, marqueeTexture);

    }

    void Update() {

        if (Input.GetMouseButtonDown(0)) {
            SelectableArea = GameObject.FindGameObjectWithTag("SelectableArea");

            float _invertedY = Screen.height - Input.mousePosition.y;
            marqueeOrigin = new Vector2(Input.mousePosition.x, _invertedY);
        }

        if (Input.GetMouseButtonUp(0)) {
            marqueeSize = Vector2.zero;
        }

        if (Input.GetMouseButton(0)) {
            float _invertedY = Screen.height - Input.mousePosition.y;
            marqueeSize = new Vector2(Input.mousePosition.x - marqueeOrigin.x, (marqueeOrigin.y - _invertedY) * -1);
        }

    }
    */
}
