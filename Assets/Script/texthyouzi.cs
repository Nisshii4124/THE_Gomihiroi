using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texthyouzi : MonoBehaviour
{
    public bool is_pressing = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        //プレイヤーtag のオブジェクトが接触したら
        if (other.gameObject.tag == "Player")
        {
            is_pressing = true;
            gameObject.SetActive(true);
        }
    }

    void OnGUI()
    {
        if (is_pressing)
        {
            // label表示
            GUI.Label(new Rect(300, 10, 150, 90), "ゴミを拾うのは↑矢印だよ");
        }
    }

}
