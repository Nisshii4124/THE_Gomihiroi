using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    public Image STAGE1_Back;
    public Image STAGE2_Back;
    public Image STAGE3_Back;
    public Image STAGE4_Back;
    public Image STAGE5_Back;
    public Image STAGE6_Back;

    Image FadeImage;          // フェードに利用する画像保存用変数

    public static float SelectStage = 1;

    bool isFadeIn;      // フェードインフラグ
    bool isFadeOut;     // フェードアウトフラグ

    float alpha;
    float alpha1;
    float alpha2;
    float alpha3;
    float alpha4;
    float alpha5;
    float alpha6;
    float hikualpha;

    // Use this for initialization
    void Start()
    {
        isFadeIn = true;  // フェードインON
        isFadeOut = false; // フェードアウトOFF

        //SelectStage = 1;

        alpha1 = 0.0f;
        alpha2 = 0.0f;
        alpha3 = 0.0f;
        alpha4 = 0.0f;
        alpha5 = 0.0f;
        alpha6 = 0.0f;
        hikualpha = 0.03f;

        // 画像のアルファ値をセット
        STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);
        STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);
        STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);
        STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);
        STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);
        STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SelectStage++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SelectStage--;
        }
        if (SelectStage == 1)
        {
            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            alpha4 = 0.0f;
            // 画像のアルファ値を変更
            STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

            alpha5 = 0.0f;
            // 画像のアルファ値を変更
            STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

            alpha6 = 0.0f;
            // 画像のアルファ値を変更
            STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha1 -= hikualpha;

                // 画像のアルファ値を変更
                STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

                // アルファ値がMIN値以下になったら
                if (STAGE1_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha1 += hikualpha ; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

                // アルファ値がMAX値以上になったら
                if (STAGE1_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }


        else if (SelectStage == 2)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            alpha4 = 0.0f;
            // 画像のアルファ値を変更
            STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

            alpha5 = 0.0f;
            // 画像のアルファ値を変更
            STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

            alpha6 = 0.0f;
            // 画像のアルファ値を変更
            STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha2 -= hikualpha ;

                // 画像のアルファ値を変更
                STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

                // アルファ値がMIN値以下になったら
                if (STAGE2_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha2 += hikualpha; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

                // アルファ値がMAX値以上になったら
                if (STAGE2_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }


        else if (SelectStage == 3)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            alpha4 = 0.0f;
            // 画像のアルファ値を変更
            STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

            alpha5 = 0.0f;
            // 画像のアルファ値を変更
            STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

            alpha6 = 0.0f;
            // 画像のアルファ値を変更
            STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha3 -= hikualpha;

                // 画像のアルファ値を変更
                STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

                // アルファ値がMIN値以下になったら
                if (STAGE3_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha3 += hikualpha; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

                // アルファ値がMAX値以上になったら
                if (STAGE3_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }


        else if (SelectStage == 4)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            alpha5 = 0.0f;
            // 画像のアルファ値を変更
            STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

            alpha6 = 0.0f;
            // 画像のアルファ値を変更
            STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha4 -= hikualpha;

                // 画像のアルファ値を変更
                STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

                // アルファ値がMIN値以下になったら
                if (STAGE4_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha4 += hikualpha; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

                // アルファ値がMAX値以上になったら
                if (STAGE4_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }


        else if (SelectStage == 5)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            alpha4 = 0.0f;
            // 画像のアルファ値を変更
            STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

            alpha6 = 0.0f;
            // 画像のアルファ値を変更
            STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha5 -= hikualpha;

                // 画像のアルファ値を変更
                STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

                // アルファ値がMIN値以下になったら
                if (STAGE5_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha5 += hikualpha; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

                // アルファ値がMAX値以上になったら
                if (STAGE5_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }


        else if (SelectStage == 6)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            alpha4 = 0.0f;
            // 画像のアルファ値を変更
            STAGE4_Back.color = new Color(STAGE4_Back.color.r, STAGE4_Back.color.g, STAGE4_Back.color.b, alpha4);

            alpha5 = 0.0f;
            // 画像のアルファ値を変更
            STAGE5_Back.color = new Color(STAGE5_Back.color.r, STAGE5_Back.color.g, STAGE5_Back.color.b, alpha5);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha6 -= hikualpha;

                // 画像のアルファ値を変更
                STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

                // アルファ値がMIN値以下になったら
                if (STAGE6_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha6 += hikualpha; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE6_Back.color = new Color(STAGE6_Back.color.r, STAGE6_Back.color.g, STAGE6_Back.color.b, alpha6);

                // アルファ値がMAX値以上になったら
                if (STAGE6_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }
        if (SelectStage <= 0) SelectStage = 1f;
        if (SelectStage >= 7) SelectStage = 6f;
    }
}

