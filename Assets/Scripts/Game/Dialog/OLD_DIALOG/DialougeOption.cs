using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DialougeTree {

    public class DialougeOption {

        public string Text;
        public int DestinationNodeID;

        public DialougeOption() { }

        public DialougeOption(string text, int destination) {
            this.Text = text;
            this.DestinationNodeID = destination;
        }
    }
}
