using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DialogueTree {
 
    public class DialogueNode {
       
        public int DialogueNodeID = -1;
        public string DialogueText;
        public List<DialogueOption> Options;        

        public DialogueNode() {
            Options = new List<DialogueOption>();           
        }
        
        public DialogueNode(string text) {
            DialogueText = text;
            Options = new List<DialogueOption>();

        }
    }
}