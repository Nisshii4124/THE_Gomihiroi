using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget_2 : MonoBehaviour
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
        if (TimeandScore.gomi <= TimeandScore.gomimax)
        {

            if (other.gameObject.tag == "Player")//tag「gomi」のついたオブジェクトにふれたら
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Destroy(gameObject);//オブジェクトを消す
                    TimeandScore.gomi += 1;
                }
            }
        }
    }
}
