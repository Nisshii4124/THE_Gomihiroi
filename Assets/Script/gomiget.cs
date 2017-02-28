using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
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
//<<<<<<< HEAD:Assets/Script/gomiget_2.cs

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す

//=======
                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
//<<<<<<< HEAD
//=======
//>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す


//<<<<<<< HEAD:Assets/Script/gomiget_2.cs

//=======
//>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs
//>>>>>>> 6cf62f48ddaf38cf792921a52dd5d9c806c865dc
                }
            }
        }
    }
}
