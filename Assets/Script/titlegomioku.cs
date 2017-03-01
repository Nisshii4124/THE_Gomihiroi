using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlegomioku : MonoBehaviour
{
    public GameObject effectPrefab;
    public Vector3 effectRtation;


    // Use this for initialization
    void Start()
    {
        // プレーヤーの位置情報等を取得
        Transform playerTransform = GameObject.Find("gomidasu1").transform;

        // ゴミをプレーヤーの場所へ
        transform.position = playerTransform.position;

    }

    void Update()
    {

    }
}