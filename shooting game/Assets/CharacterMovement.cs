using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 10f; // 移動速度

    void Update()
    {
        // WASDキーの入力を取得
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 移動方向を計算
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // キャラクターの位置を更新
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
