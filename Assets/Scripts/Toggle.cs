using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start() {
		  button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        if (ClockViz.ColorCount == 2) {
            ClockViz.ColorCount = 3;
        } else if (ClockViz.ColorCount == 3) {
            ClockViz.ColorCount = 2;
        }
	}

}
