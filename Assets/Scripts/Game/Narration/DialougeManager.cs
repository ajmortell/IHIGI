using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class DialougeManager : MonoBehaviour {

  
    private ModalPanel modalPanel;
    private DisplayManager displayManager;

    public UnityAction BtnAAction;
    public UnityAction BtnBAction;
    public UnityAction BtnCAction;
    public UnityAction BtnExitAction;
    public UnityAction BtnNextAction;

    private int counter;
    private RectTransform panelTransform;
    private Vector2 panelObjSize;
}
