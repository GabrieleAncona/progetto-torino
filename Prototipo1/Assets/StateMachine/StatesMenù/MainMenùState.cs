﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenùState : StateBehaviourBase
{
    public override void OnEnter()
    {
        ///Debug.LogFormat("SetupState {0} in Init_State", ctx.SetupDone);
        //attivare canvas
        GameManager.singleton.mc.menù.SetActive(true);
        //GameManager.singleton.MainMenu();
        
    }

    public override void OnUpdate()
    {

    }

    public override void OnExit()
    {
        //GameManager.singleton.SMController.SetTrigger("GoToInit");
    }



}
