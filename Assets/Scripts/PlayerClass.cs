using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    public string name;
    public string level;
    public int score;

    public PlayerClass (string _name, string _level, int _score)
    {
        name = _name;
        level = _level;
        score = _score;
    }

}
