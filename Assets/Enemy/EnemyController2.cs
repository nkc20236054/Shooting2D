using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 5;
    Animator anim;
    public GameObject explosionPre;

    void Start()
    {
        Destroy(gameObject,6f);
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        dir = Vector3.left;
        dir.y = Mathf.Sin(Time.time * 5f);
        
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shot"))
        {
            Instantiate(explosionPre, transform.position, Quaternion.identity);//���j�\��
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            GameDirector.lastTime -= 10f;
            Destroy(gameObject);
        }
    }
}
