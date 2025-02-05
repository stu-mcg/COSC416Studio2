using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour {
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    public UnityEvent OnResetPressed = new UnityEvent();
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            OnSpacePressed?.Invoke();
        }
        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A)){
            input += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D)){
            input += Vector2.right;
        }
        if (Input.GetKey(KeyCode.R)){
            OnResetPressed?.Invoke();
        }

        OnMove?.Invoke(input);
    }
}