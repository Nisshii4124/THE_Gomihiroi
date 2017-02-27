using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomidrop: MonoBehaviour
{
    GameObject gomiPre;

    // Use this for initialization
    void Start()
    {
        gomiPre = (GameObject)Resources.Load("otosugomi");
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeandScore.gomi != 0)
        {
            if (gomibako.gomisuteru == false)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    TimeandScore.gomi -= 1;
                    GameObject.Instantiate(gomiPre);
                }
            }
        }
    }
}