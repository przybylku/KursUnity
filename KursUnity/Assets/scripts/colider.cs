using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour
{
    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("colider");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
    }
}
