
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [Header("Object Interaction")]
    [SerializeField] private Transform PlayerCam = null;
    [SerializeField] private float interactionDistance = 5f;

    private void Update()
    {
        HandleInteraction();
    }

    public void HandleInteraction()
    {
        if(!Input.GetKeyDown(KeyCode.E)) { return; }

        Debug.Log("Started Interaction");

        RaycastHit hit;
        Physics.Raycast(PlayerCam.position, PlayerCam.forward,out hit, interactionDistance);

        if(hit.transform == null) { return; }

        if (hit.transform.GetComponent<Interactions>() == null) { return;}

        hit.transform.GetComponent<Interactions>().Interact();
    }
}
