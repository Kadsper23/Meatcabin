using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvScript : MonoBehaviour, IInteractable
{
    // variable just for this script
    GameObject player;

    void Start()
    {
        // the variable above is the GameObject Player because this found the object in unity
        player = GameObject.Find("Player");
    }

    public string GetDescription()
    {
        // if the player object in unity has the the remote in the inventory
        if (player.gameObject.GetComponent<PlayerInventory>().hasRemote == true)
        {
            return "Turn on TV";
        } else
        {
            return "Find TV Remote";
        }
    }

    public void Interact()
    {
        // and then when its interacted, it will destroy the tv. good gooding kaden :D
        if (player.gameObject.GetComponent<PlayerInventory>().hasRemote == true)
        {
            Destroy(gameObject);
        }
    }

}
