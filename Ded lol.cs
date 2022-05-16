using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dedlol : MonoBehaviour
{
    public GameObject Dedlol;


    // Start is called before the first frame update
    void Start()
    {
        Dedlol.SetActive(false);
    }

// Update is called once per frame
    void Update()
{
        If(gameHasEnded = true)
        {
            Uded();
        }
        else
        {
            Ualive();
        }
    }
}
    void Uded()
    {
        Dedlol.SetActive(true);
        Time.timeScale = 0f;
    }

    void Ualive()
    {
        Dedlol.SetActive(false);
        Time.timeScale = 1f;
    }