using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget_2 : MonoBehaviour
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
<<<<<<< HEAD
                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
=======
                    gomiflg = true;
>>>>>>> f3569c8a3df4a6c4f8c583d7d862a8f0b4da1c2f
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
