using UnityEngine;

public class tokutenn : MonoBehaviour
{
    // 得点
    private int score = 0;

    // 物体が落ちてきたときに呼び出されるメソッド
    public void ObjectDropped(GameObject droppedObject)
    {
        // 物体のタグを取得する
        string objectTag = droppedObject.tag;

        // タグに応じて得点を変える
        if (objectTag == "aka")
        {
            score += 10; // 赤の物体の場合、得点を増やす
        }
        else if (objectTag == "ao")
        {
            score += 5; // 青の物体の場合、得点を増やす
        }
        else if (objectTag == "kiiro")
        {
            score += 1; // その他の色の物体の場合、得点を増やす
        }

        Debug.Log("Score: " + score);
    }
}
