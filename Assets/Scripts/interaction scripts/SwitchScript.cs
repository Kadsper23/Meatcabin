using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour, IInteractable
{

    public Light Light;

    public bool isOn = true;

    public string GetDescription()
    {
        if (isOn)
        {
            return "Turn Off";
        } else
        {
            return "Turn On";
        }
    }

    public void Interact()
    {
        if (isOn)
        {
            Light.intensity = 0.1f;

            isOn = false;

        }
        else
        {
            Light.intensity = 1;

            isOn = true;
        }
    }
}
