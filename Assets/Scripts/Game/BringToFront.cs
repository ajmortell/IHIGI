using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringToFront : MonoBehaviour {

    Transform cameraTransform;

    private void Awake() {
        cameraTransform = Camera.main.transform;
    }

    private void OnEnable() {     
        transform.localPosition = new Vector2 (cameraTransform.localPosition.x, cameraTransform.localPosition.y);
        transform.SetAsLastSibling();
    }
}
