using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectFadeManager : MonoBehaviour
{
    public string nextSceneName1;     // 次のシーン名
    public string nextSceneName2;     // 次のシーン名
    public string nextSceneName3;     // 次のシーン名
    public string nextSceneName4;     // 次のシーン名
    public string nextSceneName5;     // 次のシーン名
    public string nextSceneName6;     // 次のシーン名

    public Image FadeImage;          // フェードに利用する画像保存用変数

    // Startメソッドで値を設定
    bool isFade;        // フェードスイッチ
    bool isFadeIn;      // フェードインフラグ
    bool isFadeOut;     // フェードアウトフラグ
    float alpha;        // アルファ値計算用変数

    // Use this for initialization
    void Start()
    {
        // シーン開始時はフェードインから始まる
        isFade = true;  // フェードON
        isFadeIn = true;  // フェードインON
        isFadeOut = false; // フェードアウトOFF
        alpha = 1.0f;  // 100％不透明

        // 最前面へ
        this.transform.SetAsLastSibling();

        // 画像のアルファ値をセット
        FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);
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
        else
        {
            // Eneterキーでフェードアウト開始し、終了後シーン遷移
            if (Input.GetKey(KeyCode.Return))
            {
                isFade = true;                   // フェードフラグON
                isFadeOut = true;                   // フェードアウトフラグON
                this.transform.SetAsLastSibling();  // 最前面へ
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
            this.transform.SetAsFirstSibling();    // 最背面へ
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
            if (StageSelect.SelectStage == 1) { SceneManager.LoadScene(nextSceneName1); }  // 次のシーンへ
            if (StageSelect.SelectStage == 2) { SceneManager.LoadScene(nextSceneName2); }  // 次のシーンへ
            if (StageSelect.SelectStage == 3) { SceneManager.LoadScene(nextSceneName3); }  // 次のシーンへ
            if (StageSelect.SelectStage == 4) { SceneManager.LoadScene(nextSceneName4); }  // 次のシーンへ
            if (StageSelect.SelectStage == 5) { SceneManager.LoadScene(nextSceneName5); }  // 次のシーンへ
            if (StageSelect.SelectStage == 6) { SceneManager.LoadScene(nextSceneName6); }  // 次のシーンへ
        }
    }
}
