using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rank : MonoBehaviour
{
    const string RANKING_PREF_KEY1 = "ranking1";            // セーブキー
    const int RANKING_NUM1         = 5;                    // セーブデータ数
    private int[] ranking1         = new int[RANKING_NUM1]; // ランキングデータ保存
    // 使いまわしするベースのテキストオブジェクト
    public GameObject baseText;

    // ランキング表示用ゲームオブジェクト
    GameObject[] rankLabel1      = new GameObject[RANKING_NUM1];

    private void Start()
    {
        // セーブデータをロード
        loadRanking1();

        // スコアをランキングに保存
        saveRanking1(TimeandScore.score);

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
        for (int i = 0; i < RANKING_NUM1; i++)
        {
            rankLabel1[i] = Instantiate(baseText);
            rankLabel1[i].transform.SetParent(FindObjectOfType<Canvas>().transform);
            rankLabel1[i].transform.SetAsFirstSibling();
            Vector2 pos = new Vector2(0, 80 + -30 * i);
            rankLabel1[i].GetComponent<RectTransform>().anchoredPosition = pos;
            rankLabel1[i].GetComponent<Text>().text = string.Format("{0}.  {1:00000}", i + 1, ranking1[i]);
        }

    }

    void Update()
    {
        // セーブデータ消去用
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteKey(RANKING_PREF_KEY1);
        }
    }

    //ランキングを PlayerPrefs から取得して ranking に格納
    private void loadRanking1()
    {
        // セーブデータをロードし、_rankingへ保存
        // セーブデータがない場合はdefaultValue = ""が_rankingへ保存される
        string _ranking = PlayerPrefs.GetString(RANKING_PREF_KEY1);

        // 文字列を「,」で分割して、整数型にし、ranking配列に格納
        if (_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(',');

            for (int i = 0; i < RANKING_NUM1; i++)
            {
                ranking1[i] = int.Parse(_score[i]);
                Debug.Log(string.Format("{0}", ranking1[i]));
            }
        }
        else
        {
            // セーブデータがない場合、すべてのスコアに０を代入
            for (int i = 0; i < RANKING_NUM1; i++)
            {
                ranking1[i] = 0;
            }
        }
    }

    // 新たにスコアを保存する
    private void saveRanking1(int new_score1)
    {
        if (ranking1[0] != 0)
        {
            // セーブデータがあるときは順次比較して、小さいほうを次の配列へ
            for (int i = 0; i < RANKING_NUM1; i++)
            {
                if (ranking1[i] < new_score1)
                {
                    int _tmp1 = ranking1[i];
                    ranking1[i] = new_score1;
                    new_score1 = _tmp1;
                }
            }
        }
        else
        {
            // セーブデータがなかったときは、先頭に代入
            ranking1[0] = new_score1;
        }

        // 「整数(int)」を「文字列(string)」に変換
        string[] str1 = new string[RANKING_NUM1];
        for (int i = 0; i < RANKING_NUM1; i++)
        {
            str1[i] = ranking1[i].ToString();
        }

        // 変換した文字列をカンマ区切りで連結し、１つの文字列へ
        string ranking_string1 = string.Join(",", str1);
        Debug.Log(string.Format("savedata1 : {0}", ranking_string1));

        // 一つにした文字列をセーブデーターとして保存
        PlayerPrefs.SetString(RANKING_PREF_KEY1, ranking_string1);
    }

}