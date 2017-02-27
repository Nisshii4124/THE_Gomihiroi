using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomioku : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // プレーヤーの位置情報等を取得
        Transform playerTransform = GameObject.Find("Player").transform;
        // ゴミをプレーヤーの場所へ
        transform.position = playerTransform.position;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
