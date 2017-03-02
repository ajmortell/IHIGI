using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectArea : MonoBehaviour {

    public bool isSelected;

    private void OnSelected()
    {
        isSelected = true;
        //renderer.material.color = Color.red;
    }

    private void OnUnselected()
    {
        isSelected = false;
        //renderer.material.color = Color.white;
    }
}
