using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Section : MonoBehaviour {

    public GameObject section = null;

    public enum SectionType { Inbox, Sent, Spam, Trash };
    public SectionType sectionType;

    public enum SectionStatus { Selected, Unselected };
    public SectionStatus sectionStatus;

    public void Awake() {
        
        section = gameObject;
        SectionType parsedType = (SectionType)System.Enum.Parse(typeof(SectionType), section.tag);
        sectionType = parsedType;
        sectionStatus = SectionStatus.Unselected;
        print("SECTION TYPE: " + parsedType);
    }

    public void setStatus(SectionStatus status) {
        sectionStatus = status;
    }

    public SectionStatus getStatus() {
        return sectionStatus;
    }

    public void setSectionType(SectionType type) {
        sectionType = type;
    }

    public SectionType getSectionType()
    {
        SectionType parsedType = (SectionType)System.Enum.Parse(typeof(SectionType), section.tag);
        sectionType = parsedType;

        return parsedType;
    }
}
