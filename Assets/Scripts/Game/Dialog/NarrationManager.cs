using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class NarrationManager : MonoBehaviour {

    private ModalPanel modalPanel;
    private DisplayManager displayManager;
    private UnityAction SkipBtnAction;
    public GameObject SceneBPanel;
    public GameObject SceneCPanel;
    public GameObject SceneDPanel;
    public GameObject expletivePanel;

    private int counter;

    void Awake() {
        counter = 0;
        modalPanel = ModalPanel.Instance();
        SceneBPanel.SetActive(false);
        SceneCPanel.SetActive(false);
        SceneDPanel.SetActive(false);
        expletivePanel.SetActive(false);
        displayManager = DisplayManager.Instance();
        SkipBtnAction = new UnityAction(OnSkipBtn);
        Narrate();
    }

    IEnumerator InitialNarative() {
        //scene a
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("Morning traffic.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("It has been a large part of your life for the past few years.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("The inevitable bumper to bumper waiting call that draws many of us out in the early hours of the morning calls you too.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("We take part in this ritual every single day in perpetual hope that we will attain great wealth from the gods of capitalism.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("Every one of us seems to have a master plan in our own ways.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("Sometimes however,");
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("more often than not,");
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("the plan");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("doesn't always go accordingly...");
        yield return new WaitForSeconds(7.0f);
        //scene b
        GoToNextPanel();
        yield return new WaitForSeconds(0.5f);
        expletivePanel.SetActive(true);
        displayManager.DisplayMessage("@#$%!!!");
        yield return new WaitForSeconds(1.5f);
        expletivePanel.SetActive(false);
        yield return new WaitForSeconds(8.0f);
        displayManager.DisplayMessage("Probability is a cruel fickle mistress.");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("One bad moment at the horizon of another creates a void where pieces of your life gets sucked away.");
        yield return new WaitForSeconds(6.0f);
        displayManager.DisplayMessage("Everything can change in a pairwise instance.");
        yield return new WaitForSeconds(6.0f);
       
        // scene c
        GoToNextPanel();
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("\n  ...");
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("You were late for work...");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("You have been fired from your job.");
        yield return new WaitForSeconds(7.0f);
       
        // scen d
        GoToNextPanel();
        yield return new WaitForSeconds(3.0f);
        displayManager.DisplayMessage("You had better go see a employment counselor tomorrow.");
        yield return new WaitForSeconds(8.0f);       
        displayManager.DisplayMessage("\n                                   The next day...                                 ");
        yield return new WaitForSeconds(6.0f);
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
