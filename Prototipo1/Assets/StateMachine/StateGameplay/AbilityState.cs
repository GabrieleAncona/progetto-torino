﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AbilityState : StateBehaviourBase
{
    private string m_MyTrigger = "GoToAbility";

    public override void OnEnter()
    {
        //Debug.LogFormat("SetupState {0} in Init_State", ctx.SetupDone);
        //ctx.previousState = "AbilityState";
        previousStateTrigger = m_MyTrigger;

        if (GameManager.singleton.acm.menuActionPlayer1.activeSelf == true)
        {
            GameManager.singleton.acm.isAbilityTank = true;
            GameManager.singleton.acm.isAbilityHealer = true;
            GameManager.singleton.acm.isAbilityUtility = true;
            GameManager.singleton.acm.isAbilityDealer = true; 
        }

        if (GameManager.singleton.acm.menuActionPlayer2.activeSelf == true)
        {
            GameManager.singleton.acm.isAbilityTank2 = true;
            GameManager.singleton.acm.isAbilityHealer2 = true;
            GameManager.singleton.acm.isAbilityUtility2 = true;
            GameManager.singleton.acm.isAbilityDealer2 = true; 
        }
        
    }

    public override void OnUpdate()
    {
        if (GameManager.singleton.acm.menuActionPlayer1.activeSelf == true)
        {
            ButtonNavigation buttonNavigation = FindObjectOfType<ButtonNavigation>();
            buttonNavigation.index = 2;
            buttonNavigation.SwitchSprite();
            buttonNavigation.text[3].SetActive(false);
            buttonNavigation.text[2].SetActive(true);
            buttonNavigation.text[1].SetActive(false);
            buttonNavigation.text[0].SetActive(false);
        }
        if (GameManager.singleton.acm.menuActionPlayer2.activeSelf == true)
        {
            ButtonNavigation buttonNavigation = FindObjectOfType<ButtonNavigation>();
            buttonNavigation.index = 2;
            buttonNavigation.SwitchSprite();
            buttonNavigation.text[3].SetActive(false);
            buttonNavigation.text[2].SetActive(true);
            buttonNavigation.text[1].SetActive(false);
            buttonNavigation.text[0].SetActive(false);
        }
    }

    public override void OnExit()
    {
        if (GameManager.singleton.acm.menuActionPlayer1.activeSelf == true)
        {
            GameManager.singleton.acm.isAbilityTank = false;
            GameManager.singleton.acm.isAbilityHealer = false;
            GameManager.singleton.acm.isAbilityUtility = false;
            GameManager.singleton.acm.isAbilityDealer = false;
            ButtonNavigation buttonNavigation = FindObjectOfType<ButtonNavigation>();
            buttonNavigation.index = 2;
            buttonNavigation.ChangeImageButton();
            if (buttonNavigation.activeab == true)
            {
                // slide back ability button
                RectTransform movedback = buttonNavigation.ability.GetComponent<RectTransform>();
                RectTransform destback = buttonNavigation.slidebacktransform[2].GetComponent<RectTransform>();
                Vector2 destination2Dback = new Vector2(movedback.anchoredPosition.x, destback.anchoredPosition.y);
                movedback.DOLocalMoveY(destination2Dback.y, 0.4f).OnComplete(() =>
                {
                    Debug.Log("ability" + destination2Dback);
                    buttonNavigation.activeab = false;
                });
            }
        }

        if (GameManager.singleton.acm.menuActionPlayer2.activeSelf == true)
        {
            GameManager.singleton.acm.isAbilityTank2 = false;
            GameManager.singleton.acm.isAbilityHealer2 = false;
            GameManager.singleton.acm.isAbilityUtility2 = false;
            GameManager.singleton.acm.isAbilityDealer2 = false;
            ButtonNavigation buttonNavigation = FindObjectOfType<ButtonNavigation>();
            buttonNavigation.index = 2;
            buttonNavigation.ChangeImageButton();
            if (buttonNavigation.activeab == true)
            {
                // slide back ability button
                RectTransform movedback = buttonNavigation.ability.GetComponent<RectTransform>();
                RectTransform destback = buttonNavigation.slidebacktransform[2].GetComponent<RectTransform>();
                Vector2 destination2Dback = new Vector2(movedback.anchoredPosition.x, destback.anchoredPosition.y);
                movedback.DOLocalMoveY(destination2Dback.y, 0.4f).OnComplete(() =>
                {
                    Debug.Log("ability" + destination2Dback);
                    buttonNavigation.activeab = false;
                });
            }
        }
    }
}
