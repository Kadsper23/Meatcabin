using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TvScript : MonoBehaviour, IInteractable
{
    public VideoPlayer Video;
    // variable just for this script
    GameObject player;
    private bool isOn = false;

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
            Video.Play();
            isOn = true;
        }
        // ask spencer about how to make it so if isOn = true AND its interacted with again, to turn it off
        //if (isOn == true) {
            //Destroy(gameObject);
        //}
    }

}
