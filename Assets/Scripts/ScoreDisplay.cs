// Deja hang
// 2/7/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    //Vars
    [SerializeField] protected TMP_Text scoreText;
    [SerializeField] protected string preText = "Score: ";
    [SerializeField] protected string postText = " pts";

    //Methods
    public void Start()
    {
        ChangeScore();
    }

    public void ChangeScore()
    {
        scoreText.text = preText + GameManager.Instance.PlayerScore + postText;
    }
}
