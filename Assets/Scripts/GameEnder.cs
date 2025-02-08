// Deja hang
// 2/7/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnder : MonoBehaviour
{
    //Methods
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.StartScene();
    }
}
