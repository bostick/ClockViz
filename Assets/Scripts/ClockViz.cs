using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockViz : MonoBehaviour
{

    public static int ColorCount = 3;

    // Update is called once per frame
    void Update()
    {
        System.DateTime now = System.DateTime.Now;

        int second = now.Second;

        int milli = now.Millisecond;

        int val = (1000 * second + milli) % 1000;

        // float hue = val / 1000.0f;

        // Color color = Color.HSVToRGB(hue, 0.5f, 0.5f);

        Color color;

        if (ColorCount == 3) {

            if (val < 333) {
                color = Color.red;
            } else if (val < 666) {
                color = Color.green;
            } else {
                color = Color.blue;
            }

        } else if (ColorCount == 2) {

            if (val < 500) {
                color = Color.red;
            } else {
                color = Color.blue;
            }

        } else {

            color = Color.red;
        }

        Camera.main.backgroundColor = color;
    }
}
