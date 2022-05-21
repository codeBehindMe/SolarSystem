using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    [Tooltip("The test to show")]
    public string displayText;
    
    public GameObject defaultTarget;
    public GameObject currentTarget;
    // Start is called before the first frame update
    void Start()
    {
        this.displayText = "Foo";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
