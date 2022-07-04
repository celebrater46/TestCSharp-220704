using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
        
        float y = Input.GetAxis("Vertical");
        Debug.Log(y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space is pressed.");
        }
    }
}
