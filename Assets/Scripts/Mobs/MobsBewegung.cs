using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MobsBewegung : MonoBehaviour
{
    private bool movementDir = false;
    private bool movementRich = false;
    void Start()
    {
        zufaelligeZahlXAchse();
        zufaelligeZahlZAchse();
    }

    void Update()
    {
        if (movementDir)
        {
            transform.position = new Vector3(transform.position.x + 0.15f, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 0.15f, transform.position.y, transform.position.z);
        }

        if (movementRich)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.15f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.15f);
        }

    }

    public void zufaelligeZahlXAchse()
    {
        int oneORtwo = Random.Range(1, 2);

        if (oneORtwo == 1)
        {
            movementDir = false;
        }
        else
        {
            movementDir = true;
        }
    }

    public void zufaelligeZahlZAchse()
    {
        int einsODERzwei = Random.Range(1, 2);

        if (einsODERzwei == 1)
        {
            movementRich = false;
        }
        else
        {
            movementRich = true;
        }
    }




}


