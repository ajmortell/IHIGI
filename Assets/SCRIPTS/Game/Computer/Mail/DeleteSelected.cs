using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class DeleteSelected : MonoBehaviour {

    private Checkbox checkbox;
    public GameObject[] checkboxes =null;

    public Toggle checkBoxToggle = null;
    public List<GameObject> mailItemFabs = null;
    
    public bool isDeleted = false;

    private void Awake() {
        checkbox = GetComponent<Checkbox>();
    }

    public void deleteItems() {
       
        foreach (GameObject item in mailItemFabs) {
            Destroy(item);
            
            Debug.Log("DESTROYED");
        }
    }

    public void iterateAndDelete() {
        checkboxes = GameObject.FindGameObjectsWithTag("CheckBox");
        
        foreach (GameObject checkBoxObject in checkboxes) { /* 1 */
           
            checkBoxToggle = checkBoxObject.GetComponent<Toggle>();
            checkbox = checkBoxToggle.GetComponent<Checkbox>();

            if (checkbox.returnSelected() == true) { /* 2 */
                mailItemFabs.Add(GameObject.FindGameObjectWithTag("MailItemFab"));
                deleteItems();
                print("DELETED");

            } else {
                print("NOT DELETED");
            } /* 2 */

        } /* 1 */
            
               
    }

    public void OnDeleteSelected() {
        iterateAndDelete();
    }
}


































/*

//private bool isDeleted = false;
//private bool canDelete = false;

public void repeatedCode(bool value) {

    checkboxes = GameObject.FindGameObjectsWithTag("CheckBox");
    foreach (GameObject checkBox in checkboxes)
    {
        checkbox = checkBox.GetComponent<Toggle>();

        if (checkbox.isOn == true)
        {
            print("DONT DELETE");
        }
        else
        {
            print("DONT DELETE");
        }
    }

}

public void OnDeleteSelected() {

    if (canDelete == true)
    {
        isDeleted = true;

        print("--DELETED:  " + isDeleted);

        repeatedCode(isDeleted);

    }
    else
    {
        isDeleted = false;

        print("--DELETED:  " + isDeleted);

        repeatedCode(isDeleted);
    }
}
*/

