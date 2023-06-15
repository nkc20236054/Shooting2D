using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float MoveSpeed = 20.0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, MoveSpeed * Time.deltaTime, 0);
        if(gameObject.transform.position.x >= 9)
        {
            Destroy(gameObject);
        }
    }
}
