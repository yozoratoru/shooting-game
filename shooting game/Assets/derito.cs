using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derito : MonoBehaviour
{
void Start()
{}

void Update()
{}

private void OnCollisionEnter(Collision collision) //ぶつかったら消える命令文開始
{
if (collision.gameObject.CompareTag("kn"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
{
Destroy(gameObject);//このゲームオブジェクトを消滅させる
}
}
}