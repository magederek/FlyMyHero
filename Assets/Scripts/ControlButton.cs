using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ControlButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler {
    public int direction;
    public Button button = null;

    private float delay = 0.01f;
    private bool _isDown = false;
    private float lastIsDownTime;

    private void Start() {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void Update() {
        
    }

    public bool isPressed() {
        if (isDown) {
            if (Time.time - lastIsDownTime > delay) {
                Debug.Log("Long press");
                lastIsDownTime = Time.time;
                return true;
            }
        }
        return false;
    }

    void TaskOnClick() {
        Debug.Log("You have clicked the button!");
    }

    public void OnPointerDown(PointerEventData eventData) {
        isDown = true;
        lastIsDownTime = Time.time;
    }

    public void OnPointerUp(PointerEventData eventData) {
        isDown = false;
    }

    public void OnPointerExit(PointerEventData eventData) {
        isDown = false;
    }

    public bool isDown {
        set { this._isDown = value; }
        get { return this._isDown;  }
    }

}
