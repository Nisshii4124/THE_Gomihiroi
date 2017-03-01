using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class gomiget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
=======
public class gomiget : MonoBehaviour
{

    Collider Hantei;

    // Use this for initialization
    void Start()
    {
        Hantei = GetComponent<Collider>();
        Hantei.enabled = false;
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
                if (Input.GetKey(KeyCode.UpArrow))

                    TimeandScore.gomi += 1;
                    Destroy(other.gameObject);//オブジェクトを消す

                }
            }
        }
    }

        


>>>>>>> ef4309bdfd6cde3ca437abe357fbc2afedba9050
