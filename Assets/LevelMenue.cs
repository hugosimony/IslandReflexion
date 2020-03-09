﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenue : MonoBehaviour
{
    public static bool OnLevel = false;

    public GameObject Level1UI;

    GameObject RefUI;


    public void Level1()
    {
        if (!OnLevel)
        {
            OnLevel = true;
            Level1UI.SetActive(true);
            RefUI = Level1UI;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public void QuitLevel()
    {
        if(OnLevel)
        {
            OnLevel = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if(RefUI != null)
            RefUI.SetActive(false);
        RefUI = null;
    }

    public static void BackButton()
    {
        OnLevel = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
