using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 5;

    void Start()
    {
        Destroy(gameObject,6f);
    }
    
    void Update()
    {
        dir = Vector3.left;
        dir.y = Mathf.Sin(Time.time * 5f);
        
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameDirector.lastTime -= 10f;

        Destroy(gameObject);
    }
}
