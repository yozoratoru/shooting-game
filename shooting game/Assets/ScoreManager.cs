using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // UIテキスト
    private int score = 0; // 現在のスコア

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ao"))
        {
            // タグが"kn"のオブジェクトと衝突した場合、スコアを増やす
            score += 10;
            Debug.Log(score);
            UpdateScoreUI();
        }else if (other.CompareTag("kuro"))
        {
            // タグが"kn"のオブジェクトと衝突した場合、スコアを増やす
            score += 20;
            Debug.Log(score);
            UpdateScoreUI();
        }else if (other.CompareTag("kiiro"))
        {
            // タグが"kn"のオブジェクトと衝突した場合、スコアを増やす
            score += 50;
            Debug.Log(score);
            UpdateScoreUI();
        }
        
    }

    void UpdateScoreUI()
    {
        // UIのテキストを更新
        scoreText.text = "Score: " + score.ToString();
    }
}
