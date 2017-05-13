using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringToFront : MonoBehaviour {

    private void OnEnable() {
        transform.SetAsLastSibling();// draws last to instance on top of anything
    }
}
