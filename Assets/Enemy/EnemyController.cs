using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 5;
    Animator anim;

    void Start()
    {
        Destroy(gameObject,4f);
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        dir = Vector3.left;
        
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shot"))
        {
            Destroy(gameObject);
            anim.SetTrigger("explosion");
        }
        if (collision.CompareTag("Player"))
        {
            GameDirector.lastTime -= 10f;
            Destroy(gameObject);
        }
    }
}
