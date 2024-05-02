using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private GameInputManager gameInputManager;
    private void Awake()
    {
        gameInputManager = new GameInputManager();
        gameInputManager.PlayerController.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = gameInputManager.PlayerController.Movement.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;
    }
}
