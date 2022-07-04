using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false); // false == hidden
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cube.SetActive(true); // true == unveil
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            cube.SetActive(false);
        }
    }
}
