using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Origin : MonoBehaviour
{
    Vector3 dir;

    Vector3 playerPos;
    Vector3 direction;

    float speed = 3.0f;
    float movetime = 0.0f;
    float addDegree = 180.0f;

    public static bool sakuteki;
    public static bool tuibi;

    //
    public Transform player;    //プレイヤーを代入
    //public float speed = 3; //移動速度
    //float addDegree = 180.0f;
    bool enemymove = true;
    float a = 0;
    //

    // Use this for initialization
    void Start()
    {
        sakuteki = true;
        tuibi = false;

        //
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (tuibi == false)
        {
            if (sakuteki == true)
            {
                dir.z = 1;
                transform.position += dir * speed * Time.deltaTime;
                movetime += Time.deltaTime;
            }
            if (sakuteki == false)
            {
                dir.z = -1;
                transform.position += dir * speed * Time.deltaTime;
                movetime += Time.deltaTime;
            }
            if (movetime >= 3)
            {
                transform.Rotate(Vector3.up, addDegree); // Y軸を基準にaddDegree度回転
                if (sakuteki == true)
                {
                    sakuteki = false;
                    movetime = 0.0f;
                }
                else if (sakuteki == false)
                {
                    sakuteki = true;
                    movetime = 0.0f;
                }
            }
        }

        /////////////////////////////////////////////
        if(tuibi == true)
        {
            dir = Vector3.zero;

            if (enemymove == true)
            {
                playerPos = player.position;    //プレイヤーの位置
                direction = playerPos - transform.position; //方向
                direction = direction.normalized;   //単位化（距離要素を取り除く）
                transform.position = transform.position + (direction * speed * Time.deltaTime);
                transform.LookAt(player);   //プレイヤーの方を向く
            }
            if (enemymove == false)
            {
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
                if (a >= 2)
                {
                    enemymove = true;
                    a = 0;
                }
            }///////////////////////////////////////////////////
        }
        if(tuibi == false)
        {
            playerPos = Vector3.zero;
            direction = Vector3.zero;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Player")
        //{
        //    tuibi = true;
        //}

        //////////////////////
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
        ///////////////////////
    }

    public void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        //    tuibi = false;
        //}
    }
}
