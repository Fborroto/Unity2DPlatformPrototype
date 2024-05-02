using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameInput gameInput;

    private float playerSpeed = 7f;


    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);
        inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * playerSpeed * Time.deltaTime;
        print(moveDir);
    }
}


