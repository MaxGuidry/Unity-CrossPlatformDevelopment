using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerBehavior : MonoBehaviour
{
    [Serializable]
    public class PlayerInfo
    {
        public int health, mana;
    }
    private  PlayerInfo thePlayer = new PlayerInfo();
    [SerializeField]
    private PlayerHealthChange HealthChanged = new PlayerHealthChange();
    [SerializeField]
    private PlayerChangeWithPlayerInfo InfoChange = new PlayerChangeWithPlayerInfo();
    void TakeDamage(int num)
    {
        thePlayer.health -= num;
        HealthChanged.Invoke();
        InfoChange.Invoke(thePlayer);
    }
	// Use this for initialization
	void Start ()
	{
	    thePlayer.health = 5;
	    thePlayer.mana = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
