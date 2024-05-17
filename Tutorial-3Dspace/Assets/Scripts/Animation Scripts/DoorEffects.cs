using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorEffects : MonoBehaviour
{

    public Animator door_animator;
    public Button door_open, door_close;

    public void OpenDoor() 
    {
        door_animator.SetBool("DoorClose", false);
        door_animator.SetBool("DoorOpen", true);
    }

    public void closeDoor() 
    {
        door_animator.SetBool("DoorOpen", false);
        door_animator.SetBool("DoorClose", true);
    }
}
