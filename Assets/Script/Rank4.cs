using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rank4 : MonoBehaviour
{
    const string RANKING_PREF_KEY4 = "ranking4";            // セーブキー
    const int RANKING_NUM4         = 5;                    // セーブデータ数
    private int[] ranking4         = new int[RANKING_NUM4]; // ランキングデータ保存

    // 使いまわしするベースのテキストオブジェクト
    public GameObject baseText;

    // ランキング表示用ゲームオブジェクト
    GameObject[] rankLabel        = new GameObject[RANKING_NUM4];

    private void Start()
    {
        // セーブデータをロード
        loadRanking4();

        // スコアをランキングに保存
        saveRanking4(TimeandScore.score);

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
        for (int i = 0; i < RANKING_NUM4; i++)
        {
            rankLabel[i] = Instantiate(baseText);
            rankLabel[i].transform.SetParent(FindObjectOfType<Canvas>().transform);
            rankLabel[i].transform.SetAsFirstSibling();
            Vector2 pos = new Vector2(0, 80 + -30 * i);
            rankLabel[i].GetComponent<RectTransform>().anchoredPosition = pos;
            rankLabel[i].GetComponent<Text>().text = string.Format("{0}.  {1:00000}", i + 1, ranking4[i]);
        }

    }

    private void Update()
    {
        // セーブデータ消去用
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteKey(RANKING_PREF_KEY4);
        }
    }

    //ランキングを PlayerPrefs から取得して ranking に格納
    private void loadRanking4()
    {
        // セーブデータをロードし、_rankingへ保存
        // セーブデータがない場合はdefaultValue = ""が_rankingへ保存される
        string _ranking4 = PlayerPrefs.GetString(RANKING_PREF_KEY4);

        // 文字列を「,」で分割して、整数型にし、ranking配列に格納
        if (_ranking4.Length > 0)
        {
            string[] _score = _ranking4.Split(',');

            for (int i = 0; i < RANKING_NUM4; i++)
            {
                ranking4[i] = int.Parse(_score[i]);
                Debug.Log(string.Format("{0}", ranking4[i]));
            }
        }
        else
        {
            // セーブデータがない場合、すべてのスコアに０を代入
            for (int i = 0; i < RANKING_NUM4; i++)
            {
                ranking4[i] = 0;
            }
        }
    }

    // 新たにスコアを保存する
    private void saveRanking4(int new_score4)
    {
        if (ranking4[0] != 0)
        {
            // セーブデータがあるときは順次比較して、小さいほうを次の配列へ
            for (int i = 0; i < RANKING_NUM4; i++)
            {
                if (ranking4[i] < new_score4)
                {
                    int _tmp4 = ranking4[i];
                    ranking4[i] = new_score4;
                    new_score4 = _tmp4;
                }
            }
        }
        else
        {
            // セーブデータがなかったときは、先頭に代入
            ranking4[0] = new_score4;
        }

        // 「整数(int)」を「文字列(string)」に変換
        string[] str4 = new string[RANKING_NUM4];
        for (int i = 0; i < RANKING_NUM4; i++)
        {
            str4[i] = ranking4[i].ToString();
        }

        // 変換した文字列をカンマ区切りで連結し、１つの文字列へ
        string ranking_string4 = string.Join(",", str4);
        Debug.Log(string.Format("savedata4 : {0}", ranking_string4));

        // 一つにした文字列をセーブデーターとして保存
        PlayerPrefs.SetString(RANKING_PREF_KEY4, ranking_string4);
    }

}