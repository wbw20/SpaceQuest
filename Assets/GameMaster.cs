using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp {
	public class GameMaster : MonoBehaviour {
		private Rect windowRect = new Rect (Screen.width - 300, Screen.height - 600, Screen.width - 200, Screen.height - 150);
		List<Planet> planets;
		
		public Font spaceQuestFont;
		
	
		// Use this for initialization
		void Start () {
			planets = new List<Planet>();
			planets.Add(new Planet("Jupiter"));
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
			GUI.Label (new Rect (10, 10, 100, 50), "Space Quest");
			
			foreach (Planet planet in planets) {
				GUI.Label (new Rect (10, 30, 100, 50), planet.getName());
			}
		}
	}
}
