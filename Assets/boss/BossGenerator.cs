using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGenerator : MonoBehaviour
{
    public GameObject BossPre;
    Vector3 sporn = Vector3.zero;

    void Start()
    {
        sporn = new Vector3(16, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameDirector.kyori == 20)
        {
            Instantiate(BossPre, sporn, Quaternion.Euler(0, 0, 0)) ;
        }
    }
}
