using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour
{
    // Destroy everything that enters the trigger
    public Light light;

    private void Start()
    {
        /*light = light.GetComponent<Light>();*/
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("colider");
        Invoke("RotateLight", 2);
    }

    private void RotateLight()
    {
        light.transform.rotation = Quaternion.Euler(-60, 0, 0);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        Invoke("light_in",2);
    }

    private void light_in()
    {
        light.transform.rotation = Quaternion.Euler(50, 0, 0);
    }
}
