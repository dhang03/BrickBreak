// Deja hang
// 2/7/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    //Vars
    protected Vector3 movDir = Vector3.zero;
    [SerializeField, Range(1,20)] protected float movSpeed = 1f;
    //[SerializeField, Range(10,29)] protected float maxSpeed = 25f;

    //Methods
    private void Update()
    {
        MovePaddle();
    }

    //Take input from action
    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 = aCon.ReadValue<Vector2>();

        movDir.x = av2.x;
        //aMovDir.z = av2.y;
    }

    public void MovePaddle()
    {
        transform.Translate(movDir * Time.deltaTime);
        
    }

    //Accessors
}
