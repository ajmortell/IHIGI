using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SectionButton : MonoBehaviour {

    public GameObject sectionButton = null;

    public enum SectionButtonType { Inbox, Sent, Spam, Trash };
    public SectionButtonType sectionButtonType;

    public enum SectionButtonStatus { Selected, Unselected };
    public SectionButtonStatus sectionButtonStatus;

    public void Awake() {
        
        sectionButton = gameObject;
        SectionButtonType parsedType = (SectionButtonType)System.Enum.Parse(typeof(SectionButtonType), sectionButton.tag);
        sectionButtonType = parsedType;
        sectionButtonStatus = SectionButtonStatus.Unselected;
        print("SECTION TYPE: " + parsedType);
    }

    public void setStatus(SectionButtonStatus status) {
        sectionButtonStatus = status;
    }

    public SectionButtonStatus getStatus() {
        return sectionButtonStatus;
    }
}
