using UnityEngine;
using UnityEngine.SceneManagement; // SceneManagerを使用するために必要

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public UIManager uiManager;

    public void AddScore(int points)
    {
        score += points;
        Debug.Log(score);
        UpdateScoreUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ao"))
        {
            score += 2;
            Debug.Log(score);
            UpdateScoreUI();
        }
        else if (other.CompareTag("kuro"))
        {
            score += 4;
            Debug.Log(score);
            UpdateScoreUI();
        }
        else if (other.CompareTag("kiiro"))
        {
            score += 6;
            Debug.Log(score);
            UpdateScoreUI();
        }
    }

    public void CalculateFinalScore()
    {
        // 最終スコアを保存
        Debug.Log("zzzzzzzzzzz");
        PlayerPrefs.SetInt("FinalScore", score);
        PlayerPrefs.Save();

        // 次のシーンに移動
        SceneManager.LoadScene("sukoahyouji"); // "sukoahyouji" を実際のシーン名に置き換えてください
    }

    private void UpdateScoreUI()
    {
        // UIのスコアを更新する処理を追加
        // uiManager.UpdateScore(score);
    }
}
