using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapDoorEffects : MonoBehaviour
{
    public Animator trap_door_hing;
    public Button trap_door_open, trap_door_close;
    
    public void Open() 
    {
        trap_door_hing.SetBool("TrapDoorClosed", false);
        trap_door_hing.SetBool("TrapDoorOpen", true);
    }

    public void Close() 
    {
        trap_door_hing.SetBool("TrapDoorOpen", false);
        trap_door_hing.SetBool("TrapDoorClosed", true);
    }
}
