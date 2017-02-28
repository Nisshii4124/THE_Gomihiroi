using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{
<<<<<<< HEAD
    Collider Hantei;

    // Use this for initialization
    void Start()
    {
        Hantei = GetComponent<Collider>();
        Hantei.enabled = false;

=======
    // Use this for initialization
    void Start()
    {
>>>>>>> 4b97977de2b9393b39cba12e546593f7cf038848
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Hantei.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Hantei.enabled = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (TimeandScore.gomi <= TimeandScore.gomimax)
        {

            if (other.gameObject.tag == "gomi")//tag「gomi」のついたオブジェクトにふれたら
            {
<<<<<<< HEAD
                    TimeandScore.gomi += 1;
                    Destroy(other.gameObject);//オブジェクトを消す
            }
        }

        
=======
                if (Input.GetKey(KeyCode.UpArrow))
                {
<<<<<<< HEAD:Assets/Script/gomiget_2.cs

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    gomiflg = true;

=======
                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
<<<<<<< HEAD
=======
                    gomiflg = true;
>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す

                    gomiflg = true;

<<<<<<< HEAD:Assets/Script/gomiget_2.cs

=======
>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs
>>>>>>> 6cf62f48ddaf38cf792921a52dd5d9c806c865dc
                }
            }
        }
>>>>>>> 4b97977de2b9393b39cba12e546593f7cf038848
    }
}
