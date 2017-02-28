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
<<<<<<< HEAD:Assets/Script/gomiget_2.cs

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    gomiflg = true;

=======
                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    gomiflg = true;
>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す

                    gomiflg = true;

<<<<<<< HEAD:Assets/Script/gomiget_2.cs

=======
>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs
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
