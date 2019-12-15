using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnObject : MonoBehaviour
{

    public GameObject obiekt;
    public int liczbaObiektow;
    private int powt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Random.Range(20f, 0f), 0.5f, Random.Range(20f, 0f));
        if(powt <= liczbaObiektow)
        {
            Instantiate(obiekt, pos, Quaternion.identity);
            powt++;
        }
        

    }
}
