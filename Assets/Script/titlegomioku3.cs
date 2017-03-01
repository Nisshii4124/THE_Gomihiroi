using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlegomioku3 : MonoBehaviour {

    public GameObject effectPrefab;

    // Use this for initialization
    void Start()
    {
        //if (effectPrefab != null)
        //{
        //    Instantiate(
        //        effectPrefab);
        //}
        // プレーヤーの位置情報等を取得
        Transform playerTransform = GameObject.Find("gomidasu3").transform;
        // ゴミをプレーヤーの場所へ
        transform.position = playerTransform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }
}