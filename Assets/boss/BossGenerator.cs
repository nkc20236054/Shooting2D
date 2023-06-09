using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGenerator : MonoBehaviour
{
    public GameObject BossPre;
    Vector3 sporn = Vector3.zero;
    float span = 50;             // 敵を出す間隔（秒）
    float delta = 0;            // 時間計算用変数\

    void Start()
    {
        sporn = new Vector3(16, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime; // 経過時間を計算
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(BossPre) ;
            go.transform.position = sporn ;
        }
    }
}
