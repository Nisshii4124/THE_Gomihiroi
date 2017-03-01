using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rank5 : MonoBehaviour
{
    const string RANKING_PREF_KEY = "ranking";            // セーブキー
    const int RANKING_NUM         = 5;                    // セーブデータ数
    int[] ranking                 = new int[RANKING_NUM]; // ランキングデータ保存

    // 使いまわしするベースのテキストオブジェクト
    public GameObject baseText;

    // ランキング表示用ゲームオブジェクト
    GameObject[] rankLabel        = new GameObject[RANKING_NUM];

    void Start()
    {
        // セーブデータをロード
        loadRanking();

        // スコアをランキングに保存
        saveRanking(TimeandScore.score);

        // 見出し
        GameObject Ranking = Instantiate(baseText); // ベースTextをコピー

        // Canvasの子オブジェクトに
        Ranking.transform.SetParent(FindObjectOfType<Canvas>().transform);

        // 最背面へ
        Ranking.transform.SetAsFirstSibling();

        // 画面中央が原点とした座標を配置
        Ranking.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 120);

        // 表示するテキスト
        Ranking.GetComponent<Text>().text = "TOP 5";

        // ランキング表示
        for (int i = 0; i < RANKING_NUM; i++)
        {
            rankLabel[i] = Instantiate(baseText);
            rankLabel[i].transform.SetParent(FindObjectOfType<Canvas>().transform);
            rankLabel[i].transform.SetAsFirstSibling();
            Vector2 pos = new Vector2(0, 80 + -30 * i);
            rankLabel[i].GetComponent<RectTransform>().anchoredPosition = pos;
            rankLabel[i].GetComponent<Text>().text = string.Format("{0}.  {1:00000}", i + 1, ranking[i]);
        }

    }

    void Update()
    {
        // セーブデータ消去用
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteKey(RANKING_PREF_KEY);
        }
    }

    //ランキングを PlayerPrefs から取得して ranking に格納
    void loadRanking()
    {
        // セーブデータをロードし、_rankingへ保存
        // セーブデータがない場合はdefaultValue = ""が_rankingへ保存される
        string _ranking = PlayerPrefs.GetString(RANKING_PREF_KEY);

        // 文字列を「,」で分割して、整数型にし、ranking配列に格納
        if (_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(',');

            for (int i = 0; i < RANKING_NUM; i++)
            {
                ranking[i] = int.Parse(_score[i]);
                Debug.Log(string.Format("{0}", ranking[i]));
            }
        }
        else
        {
            // セーブデータがない場合、すべてのスコアに０を代入
            for (int i = 0; i < RANKING_NUM; i++)
            {
                ranking[i] = 0;
            }
        }
    }

    // 新たにスコアを保存する
    void saveRanking(int new_score)
    {
        if (ranking[0] != 0)
        {
            // セーブデータがあるときは順次比較して、小さいほうを次の配列へ
            for (int i = 0; i < RANKING_NUM; i++)
            {
                if (ranking[i] < new_score)
                {
                    int _tmp = ranking[i];
                    ranking[i] = new_score;
                    new_score = _tmp;
                }
            }
        }
        else
        {
            // セーブデータがなかったときは、先頭に代入
            ranking[0] = new_score;
        }

        // 「整数(int)」を「文字列(string)」に変換
        string[] str = new string[RANKING_NUM];
        for (int i = 0; i < RANKING_NUM; i++)
        {
            str[i] = ranking[i].ToString();
        }

        // 変換した文字列をカンマ区切りで連結し、１つの文字列へ
        string ranking_string = string.Join(",", str);
        Debug.Log(string.Format("savedata : {0}", ranking_string));

        // 一つにした文字列をセーブデーターとして保存
        PlayerPrefs.SetString(RANKING_PREF_KEY, ranking_string);
    }

}