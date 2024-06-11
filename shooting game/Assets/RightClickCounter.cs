using UnityEngine;
using UnityEngine.UI;

public class RightClickCounter : MonoBehaviour
{
    public Text countText;  // カウントを表示するテキストUI
    private int count = 0;  // カウントを保持する変数

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
            count++;  // カウントを1増やす
            UpdateCountText();  // カウントを表示に反映
        }
    }

    // カウントを表示するテキストを更新
    void UpdateCountText()
    {
        countText.text = count.ToString();
    }
}
