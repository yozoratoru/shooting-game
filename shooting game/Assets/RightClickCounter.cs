using UnityEngine;
using UnityEngine.UI;

public class RightClickCounter : MonoBehaviour
{
    public Text countText;  // カウントを表示するテキストUI
    private int count = 20;  // カウントを保持する変数
    public ScoreManager scoreManager; // ScoreManagerのインスタンスを参照

    void Start()
    {
        // 初期カウントを表示
        UpdateCountText();
    }

    void Update()
    {
        // 左クリック（マウスの左ボタン）が押されたかチェック
        if (Input.GetMouseButtonDown(0))
        {
            count--;  // カウントを-1減らす
            UpdateCountText();  // カウントを表示に反映

            // カウントが0に達したら最終スコアを計算してシーンを変更
            if (count <= 0)
            {
                scoreManager.CalculateFinalScore();
            }
        }
    }

    // カウントを表示するテキストを更新
    void UpdateCountText()
    {
        countText.text = count.ToString();
    }
}