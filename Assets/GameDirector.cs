using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel;
    public Image TimeGauge;
    int kyori;

    public static float lastTime;

    void Start()
    {
        Application.targetFrameRate = 60;
        kyori = 0;
        lastTime = 100;
    }

    void Update()
    {
        lastTime -= Time.deltaTime;
        TimeGauge.fillAmount = lastTime / 100f;

        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }


}
