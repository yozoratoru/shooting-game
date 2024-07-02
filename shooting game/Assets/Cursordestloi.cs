using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursordestloi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // マウスカーソルのロックを解除
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
