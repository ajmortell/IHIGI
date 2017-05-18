using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DialougeTree
{
    public class Dialouge {
        public List<DialougeNode> Nodes;

        public void AddNode(DialougeNode node) {
            // If the node is null the node is an 'Exit' skip add
            if (node == null) {
                return;
            }
            // Add node to list of dialouge nodes
            Nodes.Add(node);
            // Assign ID to node
            node.NodeID = Nodes.IndexOf(node);
        }
    
        public void AddOption(string text, DialougeNode node, DialougeNode destination) {

            // Add the destination node to the dialouge if it's not there already
            if (!Nodes.Contains(destination)) {
                AddNode(destination);
            }
            // Add the parent node to the dialouge if not there already
            if (!Nodes.Contains(node)) {
                AddNode(node);
            }
            DialougeOption option;

            // Crerate an option object. If the destination is an 'Exit' node set index = -1
            if (destination == null) {
                option = new DialougeOption(text, -1);
            } else {
                option = new DialougeOption(text, destination.NodeID);
            }

            node.Options.Add(option);
        }

        public Dialouge() {
            Nodes = new List<DialougeNode>();
        }

        public static Dialouge LoadDialouge(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Dialouge));
            StreamReader reader = new StreamReader(path);

            Dialouge dia = (Dialouge)xml.Deserialize(reader);

            return dia;
        }

    }
}
