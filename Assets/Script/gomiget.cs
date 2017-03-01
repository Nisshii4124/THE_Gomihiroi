using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{

    Collider Hantei;

    // Use this for initialization
    void Start()
    {
        Hantei = GetComponent<Collider>();
        Hantei.enabled = false;
<<<<<<< HEAD

=======
>>>>>>> 395e9353f6196fb3eb7055649d51d2d39032ea0c
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
                


                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す



                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す



                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す
                    //gomiflg = true;



                    TimeandScore.gomi += 1;
                    Destroy(gameObject);//オブジェクトを消す





                TimeandScore.gomi += 1;
                Destroy(other.gameObject);//オブジェクトを消す


=======
>>>>>>> 395e9353f6196fb3eb7055649d51d2d39032ea0c
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    TimeandScore.gomi += 1;

                    Destroy(other.gameObject);//オブジェクトを消す

                }
<<<<<<< HEAD

=======
>>>>>>> 395e9353f6196fb3eb7055649d51d2d39032ea0c
            }
        }
    }
}

        


