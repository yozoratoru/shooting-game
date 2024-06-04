using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // UIテキスト
    private int score = 0; // 現在のスコア

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("kn"))
        {
            // タグが"kn"のオブジェクトと衝突した場合、スコアを増やす
            score += 10;
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
