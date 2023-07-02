using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject ExploPre; // �����̃v���n�u��ۑ�
    public GameObject ShotPre;  // �e�̃v���n�u��ۑ�
    float speed;                // �ړ����x��ۑ�
    Vector3 dir;                // �ړ�������ۑ�
    float rad;                  // �G�̓����T�C���J�[�u�p
    float shotTime;             // �e�̔��ˊԊu�v�Z�p
    float shotInterval = 0.3f;    // �e�̔��ˊԊu
    GameDirector gd;            // GameDirector�R���|�[�l���g��ۑ�
    public static int cnt;
    int shotcnt;

    void Start()
    {
        speed = 5;                      // �ړ����x
        dir = Vector3.left;             // �ړ�����
        shotTime = 0;                   // �e���ˊԊu�v�Z�p
        shotcnt = 0;

        // GameDirector�R���|�[�l���g��ۑ�
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();

    }

    void Update()
    {
        // �ړ�����
        transform.position += dir.normalized * speed * Time.deltaTime;

        // �G�̒e�̐���
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

    // �d�Ȃ蔻�菈��
    void OnTriggerEnter2D(Collider2D other)
    {
        // �d�Ȃ�������̃^�O���yPlayerShot�z��������
        if (other.tag == "PlayerShot")
        {
            shotcnt++;

            // �����𑝂₷
            gd.Kyori += 2000;

            // �d�Ȃ������肪�Փ˔����𐶐�
            Instantiate(ExploPre, transform.position, transform.rotation);

            // �����i�G�j�폜
            if(shotcnt >= 30)
            {
                Destroy(gameObject);
            }
        }
    }
}

