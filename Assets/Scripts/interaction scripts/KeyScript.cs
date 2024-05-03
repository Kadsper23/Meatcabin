using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyScript : MonoBehaviour, IInteractable
{

    public string key;

    public bool isResetKey;

    public string GetDescription()
    {
        return key;
    }

    public void Interact()
    { 
        if (isResetKey)
        {
            GameObject.Find("KeyBoard").GetComponent<KeyBoardBase>().CurrentCode = "";
        } else
        {
            GameObject.Find("KeyBoard").GetComponent<KeyBoardBase>().CurrentCode += key;
        }
    }
}
