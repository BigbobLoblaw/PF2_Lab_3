using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTable : MonoBehaviour
{

    public CanvasManager canvasScript;
    Hashtable myHashtable = new Hashtable();
    // Start is called before the first frame update
    void Start()
    {
        myHashtable.Add("Jacket", new PlayerClass("Jacket", "Showdown", 55000));
        myHashtable.Add("Biker", new PlayerClass("Biker", "Safehouse", 53000));
        myHashtable.Add("Richter", new PlayerClass("Richter", "Safehouse", 50000));
        myHashtable.Add("Tony", new PlayerClass("Tony", "Death Wish", 48000));
        myHashtable.Add("Jake", new PlayerClass("Jake", "Withdrawl", 45000));
    }

    // Update is called once per frame
    public void inputCheck(string _input)
    {
        if (myHashtable.ContainsKey(_input))
        {
            canvasScript.TextName.text = ((PlayerClass)myHashtable[_input]).name;
            canvasScript.TextLevel.text = ((PlayerClass)myHashtable[_input]).level;
            canvasScript.TextScore.text = ((PlayerClass)myHashtable[_input]).score.ToString();
        }
    }
}
