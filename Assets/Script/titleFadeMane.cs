using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class titleFadeMane : MonoBehaviour {
    public string nextSceneName;     // 次のシーン名
    public Image FadeImage;          // フェードに利用する画像保存用変数
    public Image UnityChan;

    // Startメソッドで値を設定
    bool isFade;        // フェードスイッチ
    bool UnityChanisFade;
    bool isFadeIn;      // フェードインフラグ
    bool isFadeOut;     // フェードアウトフラグ
    bool UnityChanisFadeIn;
    bool UnityChanisFadeOut;

    float alpha;        // アルファ値計算用変数
    float UnityChanalpha;

    // Use this for initialization
    void Start()
    {
        // シーン開始時はフェードインから始まる
        isFade = true;  // フェードON
        isFadeIn = true;  // フェードインON
        isFadeOut = false; // フェードアウトOFF
        alpha = 1.0f;  // 100％不透明

        UnityChanisFade = false;
        UnityChanisFadeIn = false;
        UnityChanisFadeOut = false;
        UnityChanalpha = 0.0f;

        // 画像のアルファ値をセット
        FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);
        UnityChan.color = new Color(UnityChan.color.r, UnityChan.color.g, UnityChan.color.b, UnityChanalpha);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFade == true)
        {
            if (isFadeIn == true)
            {
                FadeIn();    // フェードイン
            }
            if (isFadeOut == true)
            {
                FadeOut();    // フェードアウト
            }
        }

        else if (UnityChanisFade == true)
        {
            if (UnityChanisFadeIn == true)
            {
                UnityChanFadeIn();    // フェードイン
            }
            if (UnityChanisFadeOut == true)
            {
                UnityChanFadeOut();    // フェードアウト
            }
        }

        else
        {
            // Eneterキーでフェードアウト開始し、終了後シーン遷移
            if (Input.GetKey(KeyCode.Return))
            {
                if (UnityChanalpha <= 0.0f)
                {
                    isFade = true;                   // フェードフラグON
                    isFadeOut = true;                   // フェードアウトフラグON
                }
                else if (UnityChanalpha >= 1.0f)
                {
                    UnityChanisFade = true;
                    UnityChanisFadeOut = true;
                }
            }
        }
    }

    // フェードイン（透明にしていく）
    void FadeIn()
    {
        // 計算用アルファ値を減算
        alpha -= 0.04f;

        // 画像のアルファ値を変更
        FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);

        // アルファ値がMIN値以下になったら
        if (FadeImage.color.a <= 0.0f)
        {
            isFade = false;                      // フェードスイッチOFF
            isFadeIn = false;                      // フェードインフラグOFF
        }
    }

    // フェードアウト（不透明にしていく）
    void FadeOut()
    {
        alpha += 0.04f; // 計算用アルファ値を加算

        // 画像のアルファ値を変更
        FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);

        // アルファ値がMAX値以上になったら
        if (FadeImage.color.a >= 1.0f)
        {
            isFade = false;                        // フェードスイッチOFF
            isFadeOut = false;                        // フェードアウトフラグOFF

            UnityChanisFade = true;
            UnityChanisFadeIn = true;
        }
    }
    // フェードアウト（透明にしていく）
    void UnityChanFadeOut()
    {
        UnityChanalpha -= 0.04f; // 計算用アルファ値を加算

        // 画像のアルファ値を変更
        UnityChan.color = new Color(UnityChan.color.r, UnityChan.color.g, UnityChan.color.b, UnityChanalpha);

        // アルファ値がMAX値以上になったら
        if (UnityChan.color.a <= 0.0f)
        {
            isFade = false;                        // フェードスイッチOFF
            isFadeOut = false;                        // フェードアウトフラグOFF
            SceneManager.LoadScene(nextSceneName);   // 次のシーンへ
        }
    }
    void UnityChanFadeIn()
    {
        UnityChanalpha += 0.04f; // 計算用アルファ値を加算

        // 画像のアルファ値を変更
        UnityChan.color = new Color(UnityChan.color.r, UnityChan.color.g, UnityChan.color.b, UnityChanalpha);

        // アルファ値がMAX値以上になったら
        if (UnityChan.color.a >= 1.0f)
        {
            UnityChanisFade = false;                      // フェードスイッチOFF
            UnityChanisFadeIn = false;                      // フェードインフラグOFF
        }
    }
}
