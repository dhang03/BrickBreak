// Deja hang

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{

    public void LoadNextScene(int aIDX)
    {
        SceneManager.LoadScene(aIDX);
    }

    public void LoadStartScene()
    {
        GameManager.Instance.ResetScore();
        LoadNextScene(0);
    }
}
