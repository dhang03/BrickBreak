// Deja hang

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private float prayerScore = 0;

    //Methods
    public void ResetScore()
    {
        prayerScore = 0;
    }

    public void AddScore(float aScore)
    {
        prayerScore += aScore;
        foreach (ScoreDisplay sd in FindObjectsOfType<ScoreDisplay>())
        {
            sd.ChangeScore();
        }
    }

    public void NextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene >= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        }
        else {
            SceneManager.LoadScene(nextScene);
        }
        if (nextScene == 1)
        {
            ResetScore();
        }
    }

    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }


    //Accessors
    public static GameManager Instance 
    { 
        get
        {
            if (instance == null)
            {
                GameObject aGO = new GameObject("Game Manager");
                instance = aGO.AddComponent<GameManager>();
                DontDestroyOnLoad(aGO);
            }
            return instance;
        }
    }

    public float PlayerScore {get{return prayerScore;}}

}
