using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度

    void Update()
    {
        // AキーとDキーの入力を取得
        float horizontalInput = Input.GetAxis("Horizontal");

        // 移動方向を計算
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f).normalized;

        // キャラクターの位置を更新
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
