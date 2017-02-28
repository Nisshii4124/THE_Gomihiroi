using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeandScore : MonoBehaviour
{
    public static int score = 0;
    public static int gomi = 0;
    public static int gomimax = 4;

    public static bool gameFlg;  // ゲームシーンの状態

    public float lastTime;

    public Text gomiLabel;
    public Text scoreLabel;
    public Text timeLabel;      // UnityのInspectorからtimeLabelをアタッチ
    public Text timeUpLabel;      // UnityのInspectorからtimeUpLabelをアタッチ

    // Use this for initialization
    void Start()
    {
        gameFlg = true;   // ゲーム実行中のフラグをONに

        // 「TimeUp!!」はじめは非表示
        timeUpLabel.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // ゲーム終了処理
        if (gameFlg == false)
        {
            // タイムアップを表示
            timeUpLabel.GetComponent<CanvasRenderer>().SetAlpha(1.0f);

            // TimeUp の下にスコアを移動
            //Vector3 v = timeUpLabel.transform.position;
            //v.y -= 90.0f;
            //scoreLabel.rectTransform.position = v;

            return; // ここでUpdateメソッドが終了する
        }

        lastTime -= Time.deltaTime;
        lastTime = Mathf.Max(lastTime, 0.0f);   // マイナス時間にならないように

        // 残り５秒になったら赤色で点滅
        if (lastTime <= 5.0f)
        {
            // 時間が0.0fになったら、gameFlgをfalseにする
            if (lastTime == 0.0f) gameFlg = false;

            // 10フレームごとに残り時間の表示をON OFF
            if (Time.frameCount % 10 == 0)
            {
                // 残り時間のアルファ値を取得
                float alpha = timeLabel.GetComponent<CanvasRenderer>().GetAlpha();

                // アルファ値が0なら1に、1なら0に
                alpha = (alpha == 1.0f) ? 0.0f : 1.0f;

                // 赤色にしてアルファ値と一緒にセット
                Color col = new Color(1.0f, 0.0f, 0.0f, alpha);
                timeLabel.GetComponent<CanvasRenderer>().SetColor(col);
            }
        }
        scoreLabel.text = string.Format("ポイント {0:0000}", score);

        gomiLabel.text = string.Format("ゴミの数 {0}/5", gomi);

        timeLabel.text = string.Format("残り時間 {0:000}", (int)lastTime);
    }
}
