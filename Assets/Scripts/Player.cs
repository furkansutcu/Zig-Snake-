using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public class Player : MonoBehaviour
{
   
    public GameObject Pleyer;
    private float pleyerSpeed = 5f;
    private Rigidbody rb;
    public GameObject CreatedPlayer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(nameof(Move));
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CreatedPlayer"))
        {
            CubeCreator(GameManager.Instance._countTextScript.addCharacter);
        }
    }


    public void CreateCharacter(int count)
    {
        for (int i = 0; i < count; i++)
        { 
            GameObject go = Instantiate(CreatedPlayer, Vector3.back, Quaternion.identity, transform);
            go.transform.localPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z-27f);
        }
    }

    public IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            rb.velocity = new Vector3(0, 0, pleyerSpeed);
        }
    }
    public void CubeCreator(int values)
    {
        for (int i = 0; i < values; i++)
        {
            transform.DOMoveZ(transform.childCount , 0.5f).SetEase(Ease.OutElastic);
            GameObject cube = Instantiate(CreatedPlayer, transform);
            cube.transform.DOMoveZ(transform.childCount - 1.5f, 0.5f).SetEase(Ease.OutElastic);
        }
    }
    public void CubeDeleter(int value)
    {
        int characterY = 0;
        for (int i = 0; i < value; i++)
        {
            Destroy(transform.GetChild(transform.childCount - (i + 1)).gameObject);
            characterY++;
        }
        transform.DOMoveY(transform.childCount  - characterY-1 ,0.5f).SetEase(Ease.OutElastic);
    }
    // public void ChlCount()
    // {
    //     if (transform.childCount <1)
    //     {
    //         GameManager.Instance.DiedPanel.SetActive(true);
    //     }
    // }
}