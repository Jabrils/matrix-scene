using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPlay : MonoBehaviour {
    float cycle;
    float max = 60;
    bool begin;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            begin = true;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (begin)
        {
            if (cycle < Mathf.PI)
            {
                cycle += Time.deltaTime / 3;
            }
        }

        Camera.main.fieldOfView = Mathf.Abs(Mathf.Cos(cycle))*max;
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, max*.15f, max);

    }
}
