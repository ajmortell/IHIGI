using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using DialogueTree;

public class NPCDialogue : MonoBehaviour {

    // NPC
    private GameObject npc;
    private NPC npcScript;
    private string npcName;
    private int npcId;
    private Button npc_btn;
    private GameObject avatarImgPanel;
    private Image avatarImg;
    private int selected_npc = -2;
    // Dialogue
    private GameObject node_text;
    private GameObject option_1;
    private GameObject option_2;
    private GameObject option_3;
    private GameObject exit;
    private int selected_dialogue_node = -2;
    private int selected_option = -2;  
    // Data
    private Dialogue dialogue;
    private GameObject dialoguePanel;
    public string DialogueDataFilePath;
    public GameObject DialoguePanelPrefab;
    public const string path = "Assets/Resources/Dialogue/dialogues.xml";

    void Start() {
        // Dialogue
        dialogue = Dialogue.LoadDialogue(path);// loads XML
        GameObject canvas = GameObject.Find("MainCanvas"); // gets the main canvas reference
        dialoguePanel = Instantiate<GameObject>(DialoguePanelPrefab);// instantiates the panel
        dialoguePanel.transform.SetParent(canvas.transform);// sets the panel to the main canvas. bringToFront used on panel
        RectTransform dialoguePanelTransform = (RectTransform)dialoguePanel.transform;
        dialoguePanelTransform.localPosition = new Vector3(0, 0, 0);// set all to center
        node_text = GameObject.Find("DialogueText"); // this is the NPC talking
        option_1 = GameObject.Find("option_1Btn");// these are player options + exit
        option_2 = GameObject.Find("option_2Btn");
        option_3 = GameObject.Find("option_3Btn");
        exit = GameObject.Find("nextBtn");
        exit.GetComponent<Button>().onClick.RemoveAllListeners();
        exit.GetComponent<Button>().onClick.AddListener(delegate { SetSelectedOption(-1); });
        //NPC
        npc = gameObject;// this script is attached to an NPC
        npcScript = npc.GetComponent<NPC>(); // make sure we have the NPC script access on this npc
        npcId = npcScript.Id; // NPC ID. which NPC the player is speaking to
        npcName = npcScript.getName(); // NPC name for Identification and display from npc script 
        avatarImgPanel = GameObject.Find("NPCAvatarPanel");// the image panel for the NPC dialogue Avatar
        avatarImgPanel.GetComponentInChildren<Image>().sprite = npcScript.getAvatarImg();// take the NPC clicked base image and applies it to the dia av
        npc_btn = npc.GetComponent<Button>();
        dialoguePanel.SetActive(false);// turn on display for dialogue
    }

    public void RunDialogue() {
       StartCoroutine(initiate_npc_dialogue_node(dialogue.NPCNodes[npcId]));
    }

    private IEnumerator initiate_npc_dialogue_node(NPCNode node) {
       
        int node_id = 0;
        while (node_id != -1) { //
            StartCoroutine(run(node.DialogueNodes[node_id]));
            selected_dialogue_node = -2;
            print("RUNNING 1 " + node.NPCName + " DialogueNode");
            while (selected_dialogue_node == -2) {
                print("RUNNING 2 " +node.NPCName + " DialogueNode");         
                yield return new WaitForSeconds(0.25f);
            }
            node_id = selected_dialogue_node;
        } //  
        dialoguePanel.SetActive(false);
    }

    private void set_dialogue(DialogueNode node) {
        SetSelectedDialogue(node.DialogueNodeID);
    }

    private void SetSelectedDialogue(int x) {
        selected_dialogue_node = x;
    }

    public IEnumerator run(DialogueNode node) {

        dialoguePanel.SetActive(true);
        int node_id = 0;

        while (node_id != -1) { //
            display_node(node);
            selected_option = -2;
            
            while (selected_option == -2) {             
                yield return new WaitForSeconds(0.25f);
            }
            node_id = selected_option;
            
        } //
        unSelectedNPC();
    }

    private void unSelectedNPC() {
        selected_npc = -1;
    }

    private void display_node(DialogueNode node) {
        node_text.GetComponent<Text>().text = node.DialogueText;
        option_1.SetActive(false);
        option_2.SetActive(false);
        option_3.SetActive(false);

        for (int i = 0; i < node.Options.Count || i < 2; i++){
            switch (i) {
                case 0:
                    set_option_button(option_1, node.Options[i]);
                    break;
                case 1:
                    set_option_button(option_2, node.Options[i]);
                    break;
                case 2:
                    set_option_button(option_3, node.Options[i]);
                    break;
            }
        }
    }

    private void set_option_button(GameObject button, DialogueOption option) {
        button.SetActive(true);// sets sent btn ON
        button.GetComponentInChildren<Text>().text = option.OptionText;// fills text with xml option txt
        button.GetComponent<Button>().onClick.AddListener(delegate { SetSelectedOption(option.DestinationNodeID); });
    }

    private void SetSelectedOption(int x) {
        selected_option = x;     
    }
}
