using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Origin_tuiseki : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnemyMove.suitchi = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnemyMove.suitchi = false;
        }
    }
}
