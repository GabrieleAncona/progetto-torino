﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class LifeManager : MonoBehaviour {
    public int lifeTank;
    public int lifeHealer;
    public int lifeUtility;
    public int lifeDealer;
    public int lifeMaxHealer;
    public int lifeMaxUtility;
    public int lifeMaxDealer;
    public int lifeHealerPlayer2;
    public int lifeUtilityPlayer2;
    public int lifeDealerPlayer2;
    public int lifeMaxHealerPlayer2;
    public int lifeMaxUtilityPlayer2;
    public int lifeMaxDealerPlayer2;
    public int lifeTankPlayer2;
    public int lifeMaxTank;
    public int lifeMaxTankPlayer2;

    // Use this for initialization
    void Start () {

          lifeDealer = 12;
          lifeUtility = 14;
          lifeMaxUtility = lifeUtility;
          lifeMaxDealer = lifeDealer;
          lifeTank = 20;
          lifeHealer = 9;
          lifeTankPlayer2 = 20;
          lifeHealerPlayer2 = 9;
          lifeMaxTank = lifeTank;
          lifeMaxTankPlayer2 = lifeTankPlayer2;
          lifeMaxHealer = lifeHealer;
          lifeMaxHealerPlayer2 = lifeHealerPlayer2;
        lifeDealerPlayer2 = 12;
        lifeUtilityPlayer2 = 14;
        lifeMaxUtilityPlayer2 = lifeUtilityPlayer2;
        lifeMaxDealerPlayer2 = lifeDealerPlayer2;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
