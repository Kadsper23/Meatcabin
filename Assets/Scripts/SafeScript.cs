using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeScript : MonoBehaviour, IInteractable
{
    GameObject player;
    private bool IsOpen = false;

    public float originalX;
    public float originalZ;

    public float x;
    public float z;

    public float rotationX;
    public float rotationY;
    public float rotationZ;

    public float originalRotX;
    public float originalRotY;
    public float originalRotZ;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    public string GetDescription()
    {
        if (IsOpen)
        {
            return "Close Safe";
        }
        if (player.gameObject.GetComponent<PlayerInventory>().hasKey == true)
        {
            return "Open Safe";
        } else
        {
            return "Find Key";
        }
    }

    // Update is called once per frame
    public void Interact()
    {
        if (player.gameObject.GetComponent<PlayerInventory>().hasKey == true)
        {
            if (IsOpen  == false)
            {
                IsOpen = true;
                transform.position = new Vector3(x, transform.position.y, z);
                transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
            } else
            {
                transform.position = new Vector3(originalX, transform.position.y, originalZ);
                transform.rotation = Quaternion.Euler(originalRotX, originalRotY, originalRotZ);

                IsOpen = false;
            }
        }
    }
}
