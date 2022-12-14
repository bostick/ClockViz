using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start() {
		  button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
#if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
	}

}
