using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DialougeTree {

    public class DialougeNode {

        public int NodeID = -1;
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
}