using System;
using System.IO;
using DialougeTree;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DialougeTest {

public class Program {

        static void Main(string[] args) {
           
            Dialouge dia = load_dialouge("test_dia.xml");
            run_dialouge(dia);
        }

        static void run_dialouge(Dialouge dia) {
            int node_id = 0;
            while(node_id != -1) {
                node_id = run_node(dia.Nodes[node_id]);
            }
        }

        static int run_node(DialougeNode node) {
            int next_node = 1;
         //   Console.Clear();

         //   Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(node.Text);

         ///   Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Type a numerical response: ");


         //   Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < node.Options.Count; i++) {
                Console.WriteLine(String.Format("       {0}: {1}", i + 1, node.Options[i].Text));
            }

         //   Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------");

           // char key = Console.ReadKey().KeyChar;

          //  next_node = node.Options[int.Parse(key.ToString()) 1].DestinationNodeID;
            return next_node;
        }

        private static void create_dialouge() {
            Dialouge dia = new Dialouge();

            // create some nodes for test
            DialougeNode node1 = new DialougeNode("Hi welcome to test dialouge.");
            DialougeNode node2 = new DialougeNode("FUCK YOU BUDDY!");
            DialougeNode node3 = new DialougeNode("My name is [npc_name]. Who the @#$% are you!");
            DialougeNode node4 = new DialougeNode("[player_name]? @#$% that your name is Derp.");

            dia.AddNode(node1);
            dia.AddNode(node2);
            dia.AddNode(node3);
            dia.AddNode(node4);

            // 2 & 4 = Add Exit options
            dia.AddOption("Exit", node2, null);
            dia.AddOption("Exit", node4, null);

            // 1 = Add Options
            dia.AddOption("SUCK IT!", node1, node2);
            dia.AddOption("Sup.", node1, node3);
            // 3 = Add Options

            dia.AddOption("[player_name].", node1, node2);
            dia.AddOption("Call me [player_name]. Or else!", node1, node3);

            XmlSerializer xml = new XmlSerializer(typeof(Dialouge));
            StreamWriter writer = new StreamWriter("test_dia.xml");

            xml.Serialize(writer, dia);

        }

        private static Dialouge load_dialouge(string path) {
            XmlSerializer xml = new XmlSerializer(typeof(Dialouge));
            StreamReader reader = new StreamReader(path);

            Dialouge dia = (Dialouge)xml.Deserialize(reader);

            return dia;
        }
    }
}