using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	private Rect windowRect = new Rect (Screen.width - 300, Screen.height - 600, Screen.width - 200, Screen.height - 150);
	public Font spaceQuestFont;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		windowRect = GUI.Window (0, windowRect, WindowFunction, "My Window");
	}

	void WindowFunction (int windowID) {
		if (!spaceQuestFont) {
            Debug.LogError("No font found, assign one in the inspector.");
            return;
        }
		GUI.skin.font = spaceQuestFont;
		GUI.Label (new Rect (10, 10, 50, 50), "Label");
	}
}
