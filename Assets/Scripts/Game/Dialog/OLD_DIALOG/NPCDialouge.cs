using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DialougeTree;

public class NPCDialouge : MonoBehaviour {

    private Dialouge dialouge;// dia
    private GameObject dialougePanel; // dialouge_window

    private GameObject node_text;
    private GameObject option_1;
    private GameObject option_2;
    private GameObject option_3;
    private GameObject exit;

    private int selected_option = -2;
    public string DialougeDataPath;
    public GameObject DialougePanelPrefab;

    void Start() {
       
        dialouge = Dialouge.LoadDialouge("Assets/" + DialougeDataPath);
        var canvas = GameObject.Find("Canvas");
        dialougePanel = Instantiate<GameObject>(DialougePanelPrefab);
        dialougePanel.transform.parent = canvas.transform;
        RectTransform dialougePanelTransform = (RectTransform)dialougePanel.transform;
        dialougePanelTransform.localPosition = new Vector3(0, 0, 0);

        node_text = GameObject.Find("Text_DialougeNodeText");
        option_1 = GameObject.Find("Button_Option1");
        option_2 = GameObject.Find("Button_Option2");
        option_3 = GameObject.Find("Button_Option3");
        exit = GameObject.Find("Button_End");

        exit.GetComponent<Button>().onClick.AddListener(delegate { SetSelectedOption(1); });

        dialougePanel.SetActive(false);
        RunDialouge();
    }

    public void RunDialouge() {
        StartCoroutine(run());
    }

    public void SetSelectedOption(int x) {
        selected_option = x;
    }

    public IEnumerator run() {
        dialougePanel.SetActive(true);

        // create an indexer, set it to 0  the dialouges Start node.
        int node_id = 0;

        // while the next node is not an exit node, traverse the dialouge tree based on the user
        // input
        while (node_id != -1) {
            display_node(dialouge.Nodes[node_id]);
            selected_option = -2;
            while(selected_option == -2) {
                yield return new WaitForSeconds(0.25f);
            }
            node_id = selected_option;
        }
        dialougePanel.SetActive(false);
       
    }

    private void display_node(DialougeNode node) {

        node_text.GetComponent<Text>().text = node.Text;
        option_1.SetActive(false);
        option_2.SetActive(false);
        option_3.SetActive(false);

        for(int i = 0; i < node.Options.Count || i < 2; i++) {
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

    private void set_option_button(GameObject button, DialougeOption option) {
        button.SetActive(true);
        button.GetComponentInChildren<Text>().text = option.Text;
        button.GetComponent<Button>().onClick.AddListener(delegate { SetSelectedOption(option.DestinationNodeID); });
    }
    
}
