// Deja hang
// 2/7/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{

    //Vars
    [SerializeField,Range(1,20)] protected int hitsToBreak;
    [SerializeField,Range(1,20)] protected int pointValue;  
    protected int curHitsToBreak = 0;

    // break emiter
    [SerializeField] ParticleSystem hit_PS;

    public void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }

    //Methods
    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;
        hit_PS.Play();
        BreakBrick();
    }

    protected void BreakBrick()
    {
        if (curHitsToBreak <= 0)
        {
            //Add Flare before destory
            //FindObjectsOfType<RoundManager>().RemoveBrick(this);
            GameManager.Instance.AddScore(pointValue);
            Destroy(gameObject);
            //Too late for flare
            
        }
        
    }

    //Accessors
}
