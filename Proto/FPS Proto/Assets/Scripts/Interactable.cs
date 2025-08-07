using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //message displayed when looking at interactable
    public string promptMessage;
    
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //no code in this function, it is a template to be overwritten by subclasses
    }
}
