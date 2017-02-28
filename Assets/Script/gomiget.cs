using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{
    public bool gomiflg;

    // Use this for initialization
    void Start()
    {
        gomiflg = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (TimeandScore.gomi <= TimeandScore.gomimax)
        {

            if (other.gameObject.tag == "Player")//tag「gomi」のついたオブジェクトにふれたら
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {


                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    gomiflg = true;


                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    gomiflg = true;


                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す

                    gomiflg = true;


                }
            }
        }

        if (gomiflg == true)
        {         
            Destroy(gameObject);//オブジェクトを消す
            TimeandScore.gomi++;
            gomiflg = false; 
        }
    }
}
