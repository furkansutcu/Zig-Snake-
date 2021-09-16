using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
    public Player _Player;
    
    public CountTextScript _countTextScript;
    private void Awake()
    {
        Instance = this;
    }
}
