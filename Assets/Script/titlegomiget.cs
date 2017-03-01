using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlegomiget : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gomi")//tag「gomi」のついたオブジェクトにふれたら
        {

            Destroy(other.gameObject);//オブジェクトを消す

        }
    }
}