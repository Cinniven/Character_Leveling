using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    [SerializeField] private int _characterLevel = 1;
    public string characterName = "Leron";

    void Start()
    {
        //One way of calculating and outputting with saves variable.
        int _newLevel = _levelUp(characterName, _characterLevel);
        Debug.Log(_newLevel);
        //Another way of calculating and outputting, just in one line without saving the new variable.
        Debug.Log(_levelUp(characterName, _characterLevel));
    }

    /// <Summary>
    /// Takes character level and name, debug logs name and previous level.
    /// Then levels the character up once and returns the new level value.
    /// </Summary>
    private int _levelUp(string _name, int _level)
    {
        Debug.LogFormat("Character: {0} | Level: {1}", _name, _level);
        _level++;
        return _level;
    }
}