using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text text;
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Hello World (Legacy)";
        textMeshPro.text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
