using UnityEngine;

public class PanelCollision : MonoBehaviour
{
    // 衝突したときに呼び出される関数
    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトを破棄
        Destroy(collision.gameObject);

        // スコアを増やす処理を実装（仮の例）
        GameManager.Instance.AddScore(10);
    }
}
