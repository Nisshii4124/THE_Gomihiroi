using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stagechange : MonoBehaviour
{
    public Image xxxImage;
    public Sprite Stage1;
    public Sprite Stage2;
    public Sprite Stage3;
    public Sprite Stage4;
    public Sprite Stage5;
    public Sprite Stage6;
    public Sprite Stage1_1;
    public Sprite Stage2_1;
    public Sprite Stage3_1;
    public Sprite Stage4_1;
    public Sprite Stage5_1;

    float time1 = 0;
    float time2 = 0;
    float time3 = 0;
    float time4 = 0;
    float time5 = 0;

    int a = 2, b = 4;

    float alpha;        // アルファ値計算用変数

    // Use this for initialization
    void Start()
    {
        //xxxImage = GameObject.Find("XxxImage").GetComponent<Image>();
        alpha = 1.0f;  // 100％不透明
    }

    // Update is called once per frame
    void Update()
    {
        if (StageSelect.SelectStage == 1)
        {
            xxxImage.sprite = Stage1;
            time1 += Time.deltaTime;
            if (time1 >= a)
                xxxImage.sprite = Stage1_1;
            if (time1 >= b)
                time1 = 0;
        }
        else
            time1 = 0;
        if (StageSelect.SelectStage == 2)
        {
            xxxImage.sprite = Stage2;
            time2 += Time.deltaTime;
            if (time2 >= a)
                xxxImage.sprite = Stage2_1;
            if (time2 >= b)
                time2 = 0;
        }
        else
            time2 = 0;
        if (StageSelect.SelectStage == 3)
        {
            xxxImage.sprite = Stage3;
            time3 += Time.deltaTime;
            if (time3 >= a)
                xxxImage.sprite = Stage3_1;
            if (time3 >= b)
                time3 = 0;
        }
        else
            time3 = 0;
        if (StageSelect.SelectStage == 4)
        {
            xxxImage.sprite = Stage4;
            time4 += Time.deltaTime;
            if (time4 >= a)
                xxxImage.sprite = Stage4_1;
            if (time4 >= b)
                time4 = 0;
        }
        else
            time4 = 0;
        if (StageSelect.SelectStage == 5)
        {
            xxxImage.sprite = Stage5;
            time5 += Time.deltaTime;
            if (time5 >= a)
                xxxImage.sprite = Stage5_1;
            if (time5 >= b)
                time5 = 0;
        }
        else
            time5 = 0;
        if (StageSelect.SelectStage == 6)
        {
            xxxImage.sprite = Stage6;
        }
    }
}