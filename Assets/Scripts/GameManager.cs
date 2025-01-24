using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private float prayerScore = 0;

    

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

}
