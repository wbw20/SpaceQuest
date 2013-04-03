using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp {

	
	public class GameMaster : MonoBehaviour {
		public static int MAP_DIAMETER = 1000;
		
		private Rect windowRect = new Rect (Screen.width - 300, Screen.height - 600, Screen.width - 200, Screen.height - 150);
		List<Planet> planets;
		
		private Planet currentLocation;
		
		public Font spaceQuestFont;
		
	
		// Use this for initialization
		void Start () {
			planets = generatePlanets();
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
			if (GUI.Button(new Rect(10, 35, 100, 50), "Fly To")) {
				GameObject planet_button = (GameObject)Instantiate(Resources.Load("mini_planet"), transform.position, transform.rotation);
				planet_button.AddComponent("MeshFilter");
				planet_button.AddComponent("MeshRenderer");
				((MeshRenderer)planet_button.GetComponent("MeshRenderer")).renderer.material.mainTexture = (Texture)Resources.Load("mars");
			}
			
		    int spacing = 50;
			foreach (Planet planet in planets) {
				GUI.Label (new Rect (10, spacing, 100, 50), planet.getName());
				
				spacing+= 15;
			}
		}
		
		static List<Planet> generatePlanets() {
			List<Planet> generated = new List<Planet>();
			
			for (int i = MAP_DIAMETER; i <= MAP_DIAMETER*10; i += MAP_DIAMETER) {
				Planet random = new Planet(Planet.names[Random.Range(0, Planet.names.Length)]);
				random.setLocation(new Vector3(Random.Range(i, i + MAP_DIAMETER),
											  Random.Range(0, MAP_DIAMETER),
											  Random.Range(0, MAP_DIAMETER)));
				generated.Add(random);
			}
			
			return generated;
		}
	}
}
