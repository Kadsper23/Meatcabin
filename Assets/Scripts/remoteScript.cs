using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this is the script ON the remote

public class remoteScript : MonoBehaviour, IInteractable
{
    // variable just for this script 
    public GameObject player;

    public string GetDescription()
    {
        // if your looking at the remote
        return "Pick up remote";
    }

    public void Interact()
    {
        // when interacted with, it destroys the game object (remote) then changes the value of hasRemote to true.
        // Destroy GameObject destroyes whatever the script is attactched to.
        Destroy(gameObject);

        player.gameObject.GetComponent<PlayerInventory>().hasRemote = true;
    }
}
