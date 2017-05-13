using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeOption : MonoBehaviour {

    public string Text;
    public int DestinationNodeID;

    public DialougeOption() { }

    public DialougeOption(string text, int destination) {
        this.Text = text;
        this.DestinationNodeID = destination;
    }
}
