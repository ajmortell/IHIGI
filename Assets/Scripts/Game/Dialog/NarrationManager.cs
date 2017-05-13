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
    private int counter;

    void Awake() {
        counter = 0;
        modalPanel = ModalPanel.Instance();
        SceneBPanel.SetActive(false);
        SceneCPanel.SetActive(false);
        displayManager = DisplayManager.Instance();
        SkipBtnAction = new UnityAction(OnSkipBtn);
        Narrate();
    }

    IEnumerator InitialNarative() {
        //60 Seconds
        yield return new WaitForSeconds(5.0f);
        displayManager.DisplayMessage("Traffic.");
        yield return new WaitForSeconds(3.5f);
        displayManager.DisplayMessage("It has been a large part of your life for the past few years.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("The inevitable bumper to bumper waiting call that draws many of us out in the early hours of the morning.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("We take part in this ritual every single day in perpetual hope that we will attain great wealth from the monetary deities.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("Every one of us seems to have a master plan.");
        yield return new WaitForSeconds(7.0f);
        displayManager.DisplayMessage("Sometimes however,");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("more often than not,");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("the plan");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("doesn't always go accordingly...");
        yield return new WaitForSeconds(5.0f);

        GoToNextPanel();
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("@#$%!!!");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("Probability is a cruel fickle mistress.");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("One moment at the horizon of another can spell disaster if choices are not positively aligned.");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("Everything can change in a pairwise instance");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("...");
        yield return new WaitForSeconds(4.0f);
        displayManager.DisplayMessage("To wit...");
        yield return new WaitForSeconds(4.0f);

        GoToNextPanel();
        yield return new WaitForSeconds(10.0f);
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
        if (counter >= 3) {
            counter = 0;
            SceneManager.LoadScene(10);
        }
    }
}
