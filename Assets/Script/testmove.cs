using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour
{
    //キャラクターコントローラーへの参照
    CharacterController characterController;

    //アニメーターへの参照
    public Animator animator;

    //重力
    private float gravity = 20.0f;

    //移動スピード
    float speed = 1.0f;

    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;

    float moveSpeed = 4.0f;

    const float StunDuration = 1.1f;

    float recoverTime = 0.0f;

    public void Playermove()
    {
        if (IsStan()) return;

        if (inputHorizontal != 0 || inputVertical != 0)
        {
            //走るアニメーションを再生する
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }
    }

    public bool IsStan()
    {
        return recoverTime > 0.0f;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (TimeandScore.gameFlg == true)
        {
            if (IsStan())
            {
                //動きを止めて気絶状態からの復帰カウントを進める
                inputHorizontal = 0.0f;
                inputVertical = 0.0f;

                recoverTime -= Time.deltaTime;
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    inputHorizontal = 1;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    inputHorizontal = -1;
                }
                else
                {
                    inputHorizontal = 0;
                }
                if (Input.GetKey(KeyCode.W))
                {
                    inputVertical = 1;
                }

                else if (Input.GetKey(KeyCode.S))
                {
                    inputVertical = -1;
                }
                else
                {
                    inputVertical = 0;
                }
                Playermove();
            }
            if (TimeandScore.gomi >= 0)
            {
                moveSpeed = 4; ;

                if (TimeandScore.gomi >= 4)
                {
                    moveSpeed = 3; ;

                    if (TimeandScore.gomi >= 5)
                    {
                        moveSpeed = 2;
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (TimeandScore.gameFlg == true)
        {
            // カメラの方向から、X-Z平面の単位ベクトルを取得
            Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

            // 方向キーの入力値とカメラの向きから、移動方向を決定
            Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

            // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
            rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

            // キャラクターの向きを進行方向に
            if (moveForward != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveForward);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (IsStan()) return;

        if(other.gameObject.tag == "crow")
        {
            recoverTime = StunDuration;

            animator.SetTrigger("damage");

        }
    }
}