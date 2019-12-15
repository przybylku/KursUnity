using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    /*Dokumentacja
        Po dodaniu skryptu do obiektu Camera trzeba określić w inspektorze jaki obiekt ma śledzić
        */
    public Transform PlayerTransform;

    private Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPLayer = false;

    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }
    private void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        if (LookAtPLayer)
        {
            transform.LookAt(PlayerTransform);

        }
    }
    // Update is called once per frame
    void Update()
    {
           
    }
}
