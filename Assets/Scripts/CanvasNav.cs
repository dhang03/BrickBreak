using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    [SerializeField]

    public void LoadNextScene(int aIDX)
    {
        SceneManager.LoadScene(aIDX);
    }

    public void LoadStartScene()
    {
        LoadNextScene(0);
    }
}
