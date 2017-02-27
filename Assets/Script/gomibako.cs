using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomibako : MonoBehaviour
{
    public static bool gomisuteru;

    int sutetagomi;
    int scoreUp = 0;

    // Use this for initialization
    void Start()
    {
        gomisuteru = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sutetagomi == 0)
        {
            scoreUp = 1;
        }
        else if (sutetagomi <= 5)
        {
            scoreUp = 3;

            if (sutetagomi <= 4)
            {
                scoreUp = 2;

                if (sutetagomi <= 2)
                {
                    scoreUp = 1;
                }
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")//tag「gomibako」のついたオブジェクトにふれたら
        {
            gomisuteru = true;
            if (Input.GetKey(KeyCode.DownArrow))
            {
                sutetagomi = TimeandScore.gomi;
                TimeandScore.score += sutetagomi * scoreUp * 100;
                sutetagomi = 0;
                TimeandScore.gomi = 0;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gomisuteru = false;
        }
    }
}
