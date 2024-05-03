using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactScript : MonoBehaviour, IInteractable
{
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

    public string openDescription;
    public string closeDescription;

    private bool isOpen = false;

    public string GetDescription()
    {
        if (!isOpen)
        {
            return openDescription;
        } else
        {
            return closeDescription;
        }
        
    }

    public void Interact()
    {
        if (!isOpen) {
            transform.position = new Vector3(x, transform.position.y, z);
            transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

            isOpen = true;
        } else
        {
            transform.position = new Vector3(originalX, transform.position.y, originalZ);
            transform.rotation = Quaternion.Euler(originalRotX, originalRotY, originalRotZ);
            

            isOpen = false;
        }
        
    }
}
