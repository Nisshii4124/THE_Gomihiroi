using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;

    bool tuibi = true;
    float a = 0;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tuibi == true)
            agent.destination = target.transform.position;
        else if (tuibi == false)
            agent.destination = -target.transform.position;

        if (tuibi == false)
        {
            a = a + Time.deltaTime;
            if (a >= 4)
            {
                tuibi = true;
                a = 0;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //    tuibi = false;
        if (other.gameObject.tag == "field")
        {
            tuibi = false;
            if (TimeandScore.gomi > 0)
            {
                TimeandScore.gomi--;
            }
        }
    }
}
