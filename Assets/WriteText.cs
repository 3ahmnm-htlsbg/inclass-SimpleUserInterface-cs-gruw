using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteText : MonoBehaviour
{
    public InputField textInput;
    public Text textOutput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WriteToTextfield()
    {
        textOutput.text = textInput.text;
        textInput.text = "";
    }
}
