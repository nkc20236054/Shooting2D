using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGenerator : MonoBehaviour
{
    public GameObject BossPre;
    Vector3 sporn = Vector3.zero;
    float span = 50;             // “G‚ðo‚·ŠÔŠui•bj
    float delta = 0;            // ŽžŠÔŒvŽZ—p•Ï”\

    void Start()
    {
        sporn = new Vector3(16, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime; // Œo‰ßŽžŠÔ‚ðŒvŽZ
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(BossPre) ;
            go.transform.position = sporn ;
        }
    }
}
