using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{

    Collider Hantei;

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD

=======
        Hantei = GetComponent<Collider>();
        Hantei.enabled = false;
>>>>>>> 332b66383cef3293f8ffe2b717d2e5b327dfee87
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
                if (Input.GetKey(KeyCode.UpArrow))
                {
<<<<<<< HEAD
//<<<<<<< HEAD:Assets/Script/gomiget_2.cs
=======

>>>>>>> 332b66383cef3293f8ffe2b717d2e5b327dfee87

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す

<<<<<<< HEAD
//=======
                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
//<<<<<<< HEAD
//=======
//>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs
=======

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    gomiflg = true;

>>>>>>> 332b66383cef3293f8ffe2b717d2e5b327dfee87

                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す


<<<<<<< HEAD
//<<<<<<< HEAD:Assets/Script/gomiget_2.cs

//=======
//>>>>>>> 01a5b2366c78b0157f6c1cff37d9525b4aa3364c:Assets/Script/gomiget.cs
//>>>>>>> 6cf62f48ddaf38cf792921a52dd5d9c806c865dc
=======

>>>>>>> 332b66383cef3293f8ffe2b717d2e5b327dfee87
                }
=======
                TimeandScore.gomi += 1;
                Destroy(other.gameObject);//オブジェクトを消す
>>>>>>> 9595a84657f0ca04a44f09c2187fbd337f429822
            }
        }
    }
}

        


