// Deja hang
// 2/7/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //[SerializeField] protected List<BreakableBrick> bricks;
    [SerializeField] protected GameObject canvasScene;
    //Methods

    private void Update()
    {
        Debug.Log(" sdsa");
        Debug.Log(" sdsa" + FindObjectsOfType<BreakableBrick>().Length);
        EndRound();
    }
    private void Awake()
    {
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if(gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    public void RemoveBrick(BreakableBrick bb)
    {
        EndRound();
    }

    protected void EndRound()
    {
        Debug.Log(FindObjectsOfType<BreakableBrick>().Length);
        if(FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }
    }


}
