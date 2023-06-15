using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenerator : MonoBehaviour
{
    public GameObject MyShotPrefab;
    Vector3 createPosition;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            createPosition = transform.position;
            Instantiate(MyShotPrefab, createPosition,Quaternion.Euler(0,0,270));
        }
    }
}

