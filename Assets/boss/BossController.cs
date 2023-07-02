using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject ExploPre; // 爆発のプレハブを保存
    public GameObject ShotPre;  // 弾のプレハブを保存
    float speed;                // 移動速度を保存
    Vector3 dir;                // 移動方向を保存
    float rad;                  // 敵の動きサインカーブ用
    float shotTime;             // 弾の発射間隔計算用
    float shotInterval = 0.3f;    // 弾の発射間隔
    GameDirector gd;            // GameDirectorコンポーネントを保存
    public static int cnt;
    int shotcnt;

    void Start()
    {
        speed = 5;                      // 移動速度
        dir = Vector3.left;             // 移動方向
        shotTime = 0;                   // 弾発射間隔計算用
        shotcnt = 0;

        // GameDirectorコンポーネントを保存
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();

    }

    void Update()
    {
        // 移動処理
        transform.position += dir.normalized * speed * Time.deltaTime;

        // 敵の弾の生成
        shotTime += Time.deltaTime;
        if (shotTime > shotInterval)
        {
            shotTime = 0;
            Instantiate(ShotPre, transform.position, transform.rotation);
        }

        Vector3 position = transform.position;
        if(transform.position.x <= 8)
        {
            position.x = 8;
        }
        transform.position = position;
    }

    // 重なり判定処理
    void OnTriggerEnter2D(Collider2D other)
    {
        // 重なった相手のタグが【PlayerShot】だったら
        if (other.tag == "PlayerShot")
        {
            shotcnt++;

            // 距離を増やす
            gd.Kyori += 2000;

            // 重なった相手が衝突爆発を生成
            Instantiate(ExploPre, transform.position, transform.rotation);

            // 自分（敵）削除
            if(shotcnt >= 30)
            {
                Destroy(gameObject);
            }
        }
    }
}

