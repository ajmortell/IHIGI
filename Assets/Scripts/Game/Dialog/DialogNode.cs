using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeNode : MonoBehaviour {

    public int NodeID = 1;

    public string Text;

    public List<DialougeOption> Options;

    // For serialization
    public DialougeNode() {
        Options = new List<DialougeOption>();
    }

    // Constructor
    public DialougeNode(string text) {
        Text = text;
        Options = new List<DialougeOption>();
    }
}
