using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class DeleteSelected : MonoBehaviour {

    private Checkbox checkbox;
    public GameObject[] checkboxes =null;

    public Toggle checkBoxToggle = null;
    public GameObject[] mailItemFabs = null;
    
    public bool isDeleted = false;

    private void Awake() {
        checkbox = GetComponent<Checkbox>();

    }

    public void deleteItems(GameObject[] newItems) {
       
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
            Debug.Log("DESTROYED THAT @#$% YO!");
        }
    }

    public void iterateAndDelete() {
        checkboxes = GameObject.FindGameObjectsWithTag("CheckBox"); 
        //mailItemFab = GetComponent<GameObject>();
       

        foreach (GameObject checkBoxObject in checkboxes) { /* 1 */
           
            checkBoxToggle = checkBoxObject.GetComponent<Toggle>();
            checkbox = checkBoxToggle.GetComponent<Checkbox>();

            if (checkbox.returnSelected() == true) { /* 2 */

                deleteItems(mailItemFabs);
                print("DELETE");

            } else {
                print("NOT DELETE");
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

