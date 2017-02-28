using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public Transform player;    //プレイヤーを代入
    public float speed = 3; //移動速度
    float addDegree = 180.0f;
    bool enemymove = true;
    float a = 0;
    float test = 0.0f;
    public static bool suitchi = false;

    Vector3 playerPos;
    Vector3 direction;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeandScore.gameFlg == true)
        {
            //if (suitchi == true)
            //{
            if (enemymove == true)
            {
                //Vector3 playerPos = player.position;    //プレイヤーの位置
                //Vector3 direction = playerPos - transform.position; //方向
                playerPos = player.position;    //プレイヤーの位置
                direction = playerPos - transform.position; //方向
                direction = direction.normalized;   //単位化（距離要素を取り除く）
                transform.position = transform.position + (direction * speed * Time.deltaTime);
                transform.LookAt(player);   //プレイヤーの方を向く
            }
            if (enemymove == false)
            {
                //Vector3 playerPos = player.position;    //プレイヤーの位置
                //Vector3 direction = playerPos - transform.position; //方向
                playerPos = player.position;    //プレイヤーの位置
                direction = playerPos - transform.position; //方向
                direction = direction.normalized;   //単位化（距離要素を取り除く）
                transform.position = transform.position - (direction * speed * Time.deltaTime);
                transform.LookAt(player);   //プレイヤーの方を向く
                transform.Rotate(Vector3.up, -addDegree); // Y軸を基準に-addDegree度回転
            }
            if (enemymove == false)
            {
                a = a + Time.deltaTime;
                if (a >= 4)
                {
                    enemymove = true;
                    a = 0;
                }
            }
            //}
            //test += Time.deltaTime;

            //if (suitchi == false)
            //{
            //    playerPos = Vector3.zero;
            //    transform.position = transform.position + (direction * speed * Time.deltaTime);
            //}
            //if(test >= 3)
            //{
            //    suitchi = true;
            //}
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "field")
        {
            enemymove = false;
        }

        else if (other.gameObject.tag == "Player")
        {
            enemymove = false;
            if (TimeandScore.gomi > 0)
            {
                TimeandScore.gomi--;
            }
        }
    }
}