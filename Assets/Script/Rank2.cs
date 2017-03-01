using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rank2 : MonoBehaviour
{
    const string RANKING_PREF_KEY2 = "ranking";            // セーブキー
    const int RANKING_NUM2         = 5;                    // セーブデータ数
    private int[] ranking2         = new int[RANKING_NUM2]; // ランキングデータ保存

    // 使いまわしするベースのテキストオブジェクト
    public GameObject baseText;

    // ランキング表示用ゲームオブジェクト
    GameObject[] rankLabel        = new GameObject[RANKING_NUM2];

    private void Start()
    {
        // セーブデータをロード
        loadRanking2();

        // スコアをランキングに保存
        saveRanking2(TimeandScore.score);

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
        for (int i = 0; i < RANKING_NUM2; i++)
        {
            rankLabel[i] = Instantiate(baseText);
            rankLabel[i].transform.SetParent(FindObjectOfType<Canvas>().transform);
            rankLabel[i].transform.SetAsFirstSibling();
            Vector2 pos = new Vector2(0, 80 + -30 * i);
            rankLabel[i].GetComponent<RectTransform>().anchoredPosition = pos;
            rankLabel[i].GetComponent<Text>().text = string.Format("{0}.  {1:00000}", i + 1, ranking2[i]);
        }

    }

    private void Update()
    {
        // セーブデータ消去用
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteKey(RANKING_PREF_KEY2);
        }
    }

    //ランキングを PlayerPrefs から取得して ranking に格納
    private void loadRanking2()
    {
        // セーブデータをロードし、_rankingへ保存
        // セーブデータがない場合はdefaultValue = ""が_rankingへ保存される
        string _ranking = PlayerPrefs.GetString(RANKING_PREF_KEY2);

        // 文字列を「,」で分割して、整数型にし、ranking配列に格納
        if (_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(',');

            for (int i = 0; i < RANKING_NUM2; i++)
            {
                ranking2[i] = int.Parse(_score[i]);
                Debug.Log(string.Format("{0}", ranking2[i]));
            }
        }
        else
        {
            // セーブデータがない場合、すべてのスコアに０を代入
            for (int i = 0; i < RANKING_NUM2; i++)
            {
                ranking2[i] = 0;
            }
        }
    }

    // 新たにスコアを保存する
    private void saveRanking2(int new_score2)
    {
        if (ranking2[0] != 0)
        {
            // セーブデータがあるときは順次比較して、小さいほうを次の配列へ
            for (int i = 0; i < RANKING_NUM2; i++)
            {
                if (ranking2[i] < new_score2)
                {
                    int _tmp = ranking2[i];
                    ranking2[i] = new_score2;
                    new_score2 = _tmp;
                }
            }
        }
        else
        {
            // セーブデータがなかったときは、先頭に代入
            ranking2[0] = new_score2;
        }

        // 「整数(int)」を「文字列(string)」に変換
        string[] str2 = new string[RANKING_NUM2];
        for (int i = 0; i < RANKING_NUM2; i++)
        {
            str2[i] = ranking2[i].ToString();
        }

        // 変換した文字列をカンマ区切りで連結し、１つの文字列へ
        string ranking_string2 = string.Join(",", str2);
        Debug.Log(string.Format("savedata2 : {0}", ranking_string2));

        // 一つにした文字列をセーブデーターとして保存
        PlayerPrefs.SetString(RANKING_PREF_KEY2, ranking_string2);
    }

}