using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public InputField Input;
    public Text TextName;
    public Text TextLevel;
    public Text TextScore;

    public HashTable hashtableScript;

    // Start is called before the first frame update
    void Start()
    {
        if(Input)
        {
            Input.onEndEdit.AddListener((_input) => hashtableScript.inputCheck(_input));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
