using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKeyScript : MonoBehaviour, IInteractable
{
    public GameObject player;
    public string GetDescription()
    {
        return "Pick up Key";
    }

    public void Interact()
    {
        Destroy(gameObject);
        player.gameObject.GetComponent<PlayerInventory>().hasKey = true;
    }

}
