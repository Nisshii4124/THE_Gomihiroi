using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rank3 : MonoBehaviour
{
    const string RANKING_PREF_KEY3 = "ranking3";            // セーブキー
    const int RANKING_NUM3         = 5;                    // セーブデータ数
    private int[] ranking3         = new int[RANKING_NUM3]; // ランキングデータ保存

    // 使いまわしするベースのテキストオブジェクト
    public GameObject baseText;

    // ランキング表示用ゲームオブジェクト
    GameObject[] rankLabel        = new GameObject[RANKING_NUM3];

    private void Start()
    {
        // セーブデータをロード
        loadRanking3();

        // スコアをランキングに保存
        saveRanking3(TimeandScore.score);

        // 見出し
        GameObject Ranking = Instantiate(baseText); // ベースTextをコピー

        // Canvasの子オブジェクトに
        Ranking.transform.SetParent(FindObjectOfType<Canvas>().transform);

        // 最背面へ
        Ranking.transform.SetAsFirstSibling();

        // 画面中央が原点とした座標を配置
        Ranking.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 120);

        // 表示するテキスト
        Ranking.GetComponent<Text>().text = "   TOP 5";

        // ランキング表示
        for (int i = 0; i < RANKING_NUM3; i++)
        {
            rankLabel[i] = Instantiate(baseText);
            rankLabel[i].transform.SetParent(FindObjectOfType<Canvas>().transform);
            rankLabel[i].transform.SetAsFirstSibling();
            Vector2 pos = new Vector2(0, 80 + -30 * i);
            rankLabel[i].GetComponent<RectTransform>().anchoredPosition = pos;
            rankLabel[i].GetComponent<Text>().text = string.Format("{0}.  {1:00000}", i + 1, ranking3[i]);
        }

    }

    private void Update()
    {
        // セーブデータ消去用
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteKey(RANKING_PREF_KEY3);
        }
    }

    //ランキングを PlayerPrefs から取得して ranking に格納
    private void loadRanking3()
    {
        // セーブデータをロードし、_rankingへ保存
        // セーブデータがない場合はdefaultValue = ""が_rankingへ保存される
        string _ranking = PlayerPrefs.GetString(RANKING_PREF_KEY3);

        // 文字列を「,」で分割して、整数型にし、ranking配列に格納
        if (_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(',');

            for (int i = 0; i < RANKING_NUM3; i++)
            {
                ranking3[i] = int.Parse(_score[i]);
                Debug.Log(string.Format("{0}", ranking3[i]));
            }
        }
        else
        {
            // セーブデータがない場合、すべてのスコアに０を代入
            for (int i = 0; i < RANKING_NUM3; i++)
            {
                ranking3[i] = 0;
            }
        }
    }

    // 新たにスコアを保存する
    private void saveRanking3(int new_score3)
    {
        if (ranking3[0] != 0)
        {
            // セーブデータがあるときは順次比較して、小さいほうを次の配列へ
            for (int i = 0; i < RANKING_NUM3; i++)
            {
                if (ranking3[i] < new_score3)
                {
                    int _tmp3 = ranking3[i];
                    ranking3[i] = new_score3;
                    new_score3 = _tmp3;
                }
            }
        }
        else
        {
            // セーブデータがなかったときは、先頭に代入
            ranking3[0] = new_score3;
        }

        // 「整数(int)」を「文字列(string)」に変換
        string[] str3 = new string[RANKING_NUM3];
        for (int i = 0; i < RANKING_NUM3; i++)
        {
            str3[i] = ranking3[i].ToString();
        }

        // 変換した文字列をカンマ区切りで連結し、１つの文字列へ
        string ranking_string3 = string.Join(",", str3);
        Debug.Log(string.Format("savedata3 : {0}", ranking_string3));

        // 一つにした文字列をセーブデーターとして保存
        PlayerPrefs.SetString(RANKING_PREF_KEY3, ranking_string3);
        
    }

}