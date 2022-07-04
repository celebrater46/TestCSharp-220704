using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeA_TestInvokeRepeating_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn1", 1f, 1f);
        InvokeRepeating("Spawn2", 1.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn1()
    {
        gameObject.SetActive(false);
    }

    void Spawn2()
    {
        gameObject.SetActive(true);
    }
}
