using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class CountTextScript : MonoBehaviour
{
    public Text textCounter;
   //public Text textXXX;
    public int addCharacter = 0;
   // public int xxaddCharacter = 0;
    void Start()
    {
        int min = 7;
        int max = 60;
        addCharacter = Random.Range(min, max);
       // xxaddCharacter = Random.Range(2, 3);
        textCounter.text = addCharacter.ToString();
       // textXXX.text = xxaddCharacter.ToString();
    }
    void Update()
    {
    }
    public void randomSayi()
    {
        textCounter.text = (+Convert.ToInt32(Random.Range(1, 20))).ToString();
        textCounter.text = addCharacter.ToString();
    }
}