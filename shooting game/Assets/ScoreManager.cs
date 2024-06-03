using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // 得点
    private int score = 0;
    
    // 得点を表示するTMPテキスト
    public TMP_Text scoreText;

    // 物体が落ちてきたときに呼び出されるメソッド
    public void ObjectDropped(GameObject droppedObject)
    {
        // 色を判別する処理など
        
        // 得点を増やす処理など
        
        // スコアを更新してTMPテキストに反映する
        UpdateScoreUI();
    }

    // TMPテキストに得点を表示するメソッド
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
