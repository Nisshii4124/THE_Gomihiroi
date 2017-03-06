using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stagechange : MonoBehaviour
{
    public Image xxxImage;
    public Sprite xxxImage1;
    public Sprite xxxImage2;
    public Sprite xxxImage3;
    public Sprite xxxImage4;
    public Sprite xxxImage5;
    public Sprite xxxImage6;


    // Use this for initialization
    void Start ()
    {
        //xxxImage = GameObject.Find("XxxImage").GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (StageSelect.SelectStage == 1)
        {
            xxxImage.sprite = xxxImage1;
        }
        else if (StageSelect.SelectStage == 2)
        {
            xxxImage.sprite = xxxImage2;
        }
        else if (StageSelect.SelectStage == 3)
        {
            xxxImage.sprite = xxxImage3;
        }
        else if (StageSelect.SelectStage == 4)
        {
            xxxImage.sprite = xxxImage4;
        }
        else if (StageSelect.SelectStage == 5)
        {
            xxxImage.sprite = xxxImage5;
        }
        else if (StageSelect.SelectStage == 6)
        {
            xxxImage.sprite = xxxImage6;
        }
    }
}
