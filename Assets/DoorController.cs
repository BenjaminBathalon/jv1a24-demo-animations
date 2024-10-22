using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    
    [SerializeReference] Animator door;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Yes")
            door.SetBool("IsOpen", true)
        }
    }

    private void OnTriggerExit(Collider other)
    {
         if(other.CompareTag("Player")){
            print("No")
            door.SetBool("IsOpen", false)
        }
    }
}
