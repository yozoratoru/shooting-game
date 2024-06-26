using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        Debug.Log("load start");
        // PlayerPrefsからスコアを読み込む
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        Debug.Log("finalScore"+finalScore);

        // UIにスコアを表示
        Debug.Log("aaaaaaaaaaa"+finalScore);
        scoreText.text = "Final Score: " + finalScore.ToString();
    }
}
