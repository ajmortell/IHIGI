using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;
using DialougeTree;

public class NarrationManager : MonoBehaviour {

    private Dialouge dialouge;
    private ModalPanel modalPanel;
    private DisplayManager displayManager;
    private UnityAction SkipBtnAction;
    public GameObject SceneBPanel;
    public GameObject SceneCPanel;
    public GameObject SceneDPanel;
    public GameObject CellCallingPanel;
    public GameObject CellAnswerPanel;
    public GameObject TalkBubblePanel;
    public GameObject expletivePanel;

    private int counter;
    private RectTransform panelTransform;
    private Vector2 panelObjSize;

    void Awake() {
        counter = 0;
        modalPanel = ModalPanel.Instance();
        SceneBPanel.SetActive(false);
        SceneCPanel.SetActive(false);
        SceneDPanel.SetActive(false);
        CellCallingPanel.SetActive(false);
        CellAnswerPanel.SetActive(false);
        TalkBubblePanel.SetActive(false);
        expletivePanel.SetActive(false);

        displayManager = DisplayManager.Instance();
        SkipBtnAction = new UnityAction(OnSkipBtn);
        this.panelTransform = modalPanel.getPanelTransform();
        this.panelObjSize = modalPanel.getPanelSize();

        Narrate();
    }

    
    IEnumerator InitialNarative() {
        //scene a
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("Morning traffic.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("It has been a large part of your life for the past few years.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("The inevitable bumper to bumper waiting call that draws many of us out in the early hours of the morning.");
        yield return new WaitForSeconds(7.0f);

        displayManager.DisplayMessage("We are each called to our destination.");
        yield return new WaitForSeconds(7.0f);

        displayManager.DisplayMessage("We go out on a quest in perpetual hope that we will attain great wealth from the kings of capitalism.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("Most of us seem to have a master plan to attain this goal in our own ways.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("Just like anything else however...");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("...A master plan");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("is a slave to probability.");
        yield return new WaitForSeconds(7.0f);
        //scene b
        GoToNextPanel();
        yield return new WaitForSeconds(0.5f);
        expletivePanel.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        displayManager.DisplayMessage("...");
        yield return new WaitForSeconds(1.5f);
        expletivePanel.SetActive(false);
        yield return new WaitForSeconds(8.0f);
        displayManager.DisplayMessage("Probability is a cruel fickle mistress.");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("One bad moment at the horizon of another creates a void where pieces of your life get sucked away.");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("Everything can change in a pairwise instance.");
        yield return new WaitForSeconds(6.0f); 
        // scene c
        GoToNextPanel();
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("\n  !!!");
        yield return new WaitForSeconds(5.0f);
        displayManager.DisplayMessage("You were late for work...");
        yield return new WaitForSeconds(2.0f);
        TalkBubblePanel.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        TalkBubblePanel.SetActive(false);
        displayManager.DisplayMessage("You have been fired from your job.");
        yield return new WaitForSeconds(7.0f);      
        // scen d
        GoToNextPanel();
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("\n                                   One week later...                                 ");
        yield return new WaitForSeconds(7.0f);

        // cell phone rings
        // 1. play audio
        // 2. black screen
        yield return new WaitForSeconds(4.0f);
        // cell phone answered
        // 1. stop audio
        // 2. cell caller graphics panel active
        CellCallingPanel.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        // cell display changes when answered to 'on' call screen
        CellCallingPanel.SetActive(false);
        CellAnswerPanel.SetActive(true);
        // 1. cell caller prahics inactive
        // 2. cell answered graphics active
        yield return new WaitForSeconds(2.0f);
        // start new dialouge
        displayManager.DisplayMessage("Hello?");
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("Honey, it's your mother.");
        yield return new WaitForSeconds(5.0f);
        displayManager.DisplayMessage("Are you ok?");
        yield return new WaitForSeconds(5.0f);
        displayManager.DisplayMessage("I heard the bad news.");
        yield return new WaitForSeconds(5.0f);
        displayManager.DisplayMessage("Well... all you can do is pick yourslef up and try again.");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("You should go see a job counselor in the morning.");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("I know just the place!");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("I will text you the address");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("It will all work out fine.");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("Change can be a good thing.");
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("Bye Bye honey!");
        yield return new WaitForSeconds(8.0f);
        CellAnswerPanel.SetActive(false);
        yield return new WaitForSeconds(4.0f);       
        displayManager.DisplayMessage("\n                                   The next day...                                 ");
        yield return new WaitForSeconds(7.0f);
        // exit
        GoToNextPanel();
    }

    public void Narrate() {
        modalPanel.Narrative(SkipBtnAction);
        StartCoroutine(InitialNarative());
    }
    
    void OnSkipBtn() {
        SceneManager.LoadScene(10);
    }

    // add new scenes = add new ifs before last
    void GoToNextPanel() {
        counter++;

        if (counter ==1) {
            SceneBPanel.SetActive(true);
        }
        if (counter == 2) {
            SceneCPanel.SetActive(true);
        }

        if (counter == 3)
        {
            SceneDPanel.SetActive(true);
        }
        if (counter >= 4) {
            counter = 0;
            SceneManager.LoadScene(10);
        }
    }
}
