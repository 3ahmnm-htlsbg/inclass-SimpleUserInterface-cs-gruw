using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterOutput;
    public int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        counterOutput.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountUp()
    {
        counter += 1;
        counterOutput.text = counter.ToString();
    }
}
