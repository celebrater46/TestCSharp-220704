using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeA_TestCoroutine_Controller : MonoBehaviour
{
    private int Count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        // Coroutine means that repeating function
        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator move()
    {
        while (Count < 21)
        {
            transform.Translate(0, 0.2f, 0);
            Count++;
            yield return null;
        }
    }
}
