
using UnityEngine;
using UnityEngine.Events;

public class Interactions : MonoBehaviour
{
    public UnityEvent onInteract;
    public void Interact()
    {
        onInteract?.Invoke();
    }
}
