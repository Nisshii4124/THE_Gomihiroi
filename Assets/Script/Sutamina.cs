using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Sutamina : MonoBehaviour {

    public float Dash;    //ダッシュの倍率
    public bool DashFlag; //ダッシュできるかどうか

    public float sutamina;//スタミナ
    Slider SUTAMINA;

    public float ReCaver;
    bool ReCaverOK;

    testmove player;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        SUTAMINA = GameObject.Find("Slider").GetComponent<Slider>();        

        sutamina = SUTAMINA.maxValue;
    }
	
	// Update is called once per frame
	void Update () {

        SUTAMINA.value = sutamina;

        if (ReCaver >= 10.0f)
        {
            ReCaverOK = true;
        }
        else
        {
            ReCaverOK=false;
        }

        if (SUTAMINA.value != SUTAMINA.minValue && ReCaverOK == true)
        {
            Dash = 5 / (TimeandScore.gomi + 1) ;

            if (Input.GetKeyDown(KeyCode.LeftShift) && rb.velocity.magnitude != 0)
            {
                DashFlag = true;
                sutamina -= TimeandScore.gomi * Time.deltaTime;
                
            }
            else
            {
                sutamina += Time.deltaTime;
                DashFlag = false;
            }
        }
        else//スタミナが0まで下がったら10秒間ダッシュ出来なくする
        {
            DashFlag = false;
            Dash = 0.5f;
            ReCaverOK = false;
            ReCaver = 0;
            sutamina += Time.deltaTime;
        }
        ReCaver += Time.deltaTime;

        //sutaminaが上限下限を超えないように調整
        if (sutamina <= SUTAMINA.minValue)
        {
            sutamina = SUTAMINA.minValue;
        }
        if (sutamina >= SUTAMINA.maxValue)
        {
            sutamina = SUTAMINA.maxValue;
        }
	}
}
