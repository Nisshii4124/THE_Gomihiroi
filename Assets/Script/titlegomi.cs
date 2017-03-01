using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlegomi : MonoBehaviour
{

    GameObject gomiPre;
    GameObject gomiPre2;
    GameObject gomiPre3;

    float a = 0;

    public static bool gomi = false;
    // Use this for initialization
    void Start()
    {
        gomiPre = (GameObject)Resources.Load("titlegomi");
        gomiPre2 = (GameObject)Resources.Load("titlegomi2");
        gomiPre3 = (GameObject)Resources.Load("titlegomi3");
    }

    // Update is called once per frame
    void Update()
    {
        if (gomi == true)
        {
            GameObject.Instantiate(gomiPre);
            GameObject.Instantiate(gomiPre2);
            GameObject.Instantiate(gomiPre3);

            a += Time.deltaTime;
            if(a>= 1)
            gomi = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gomi = true;
            other.gameObject.transform.position = new Vector3(9.0f, 0.5f, 0.0f);
        }
    }
}