using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        // PlayerPrefsからスコアを読み込む
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        // UIにスコアを表示
        Debug.Log("aaaaaaaaaaa"+finalScore);
        scoreText.text = "Final Score: " + finalScore.ToString();
    }
}
