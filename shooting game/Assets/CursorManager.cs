using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        // ゲーム開始時にカーソルを中央にロックし、非表示にする
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // 仮にエスケープキーを押すとカーソルをロック解除し、表示する
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
