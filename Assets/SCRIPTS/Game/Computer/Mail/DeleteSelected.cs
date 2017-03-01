using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class DeleteSelected : MonoBehaviour {

    public GameObject[] checkboxes;
    public Checkbox checkbox;
    public Toggle checkBoxToggle = null;
    public GameObject mailItemFab;
    public GameObject[] mailItemFabs;
    public bool isDeleted = false;

    public void iterateAndDelete()
    {
        checkboxes = GameObject.FindGameObjectsWithTag("CheckBox");

        mailItemFab = GetComponent<GameObject>();
//        mailItemFabs = GameObject.FindGameObjectsWithTag("CheckBox");

      

            foreach (GameObject checkBoxObject in checkboxes)
            { /* 1 */
            
                checkBoxToggle = checkBoxObject.GetComponent<Toggle>();
                checkbox = checkBoxToggle.GetComponent<Checkbox>();

                if (checkbox.returnSelected() == true) {

                
                print("DELETE");
                    

                } else {

                    print("NOT DELETE");
                }
            } /* 1 */
            
            //
            //      
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

