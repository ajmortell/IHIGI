using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class TestModalWindow : MonoBehaviour {

    private ModalPanel modalPanel;
    private DisplayManager displayManager;

    private UnityAction SkipBtnAction;
    private UnityAction NextBtnAction;
    //private UnityAction ChoiceAAction;
    //private UnityAction ChoiceBAction;
    //private UnityAction ChoiceCAction;
    //private UnityAction OKBtnAction;

    void Awake () {
        modalPanel = ModalPanel.Instance();
        displayManager = DisplayManager.Instance();

        SkipBtnAction = new UnityAction(TestSkipBtnFunction);
        NextBtnAction = new UnityAction(TestNextBtnFunction);

        //ChoiceAAction = new UnityAction(TestChoiceAFunction);
        //ChoiceBAction = new UnityAction(TestChoiceBFunction);
        //ChoiceCAction = new UnityAction(TestChoiceCFunction);

        //OKBtnAction = new UnityAction(TestOKBtnFunction);
    }
	
    // Send to the Modal Panel to set up the Buttons and Functions to call
    public void TestChoices() {
        //modalPanel.Choice("....", ChoiceAAction, ChoiceBAction, ChoiceCAction);
    }

    public void TestInfo() {
        //modalPanel.Narrative("Traffic. It is all you have known for the past few years. The inevitable bumper to bumper waiting call that draws many of us out in the early hours of the morning.", BtnAAction, BtnBAction);
    }

    // These are wrapped into UnityAction
    void TestChoiceAFunction() {
        displayManager.DisplayMessage("This is choice A");
    }

    void TestChoiceBFunction() {
        displayManager.DisplayMessage("This is choice B. YEAP!");
    }

    void TestChoiceCFunction() {
        displayManager.DisplayMessage("This is choice C Dude.");
    }

    void TestSkipBtnFunction() {
        displayManager.DisplayMessage("This is the skip btn.");
    }

    void TestNextBtnFunction() {
        displayManager.DisplayMessage("We take part in this ritual every single day in perpetual hope that we will attain great wealth. Everyone seems to have a master plan. Sometimes however, more often than not, the plan doesn't go accordingly...");
    }

    void TestOKBtnFunction() {
        displayManager.DisplayMessage("OK...");
    }
}
