using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] float shootForce;
    [SerializeField] int magazineSize;
    public GameObject gun; // 銃のGameObjectをアタッチする
    public Transform gunBarrel; // 銃口のTransformをアタッチする
    private GameObject bulletPrefab; // 弾のPrefabをアタッチする
    public float bulletSpeed = 20f; // 弾の速度


    void Start()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
        bulletPrefab = (GameObject)Resources.Load("bullet");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 右クリックの検出
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        if (bulletRB != null)
        {
            // float z = bulletRB.position.z + shootForce * bulletSpeed;
            bulletRB.AddForce(Vector3.back * shootForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Rigidbody is not attached to the bullet!");
        }
    }
}
