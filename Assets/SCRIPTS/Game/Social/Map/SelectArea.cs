using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectArea : MonoBehaviour {

    public bool isSelected;

    private void OnSelected()
    {
        isSelected = true;
        
    }

    private void OnUnselected()
    {
        isSelected = false;
        
    }
}
