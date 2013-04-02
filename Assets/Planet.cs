using System;
using UnityEngine;

namespace AssemblyCSharp {
	public class Planet {
		private String name;
		private Vector3 location;
		
		public static String[] names = {
			"Earth",
			"Mars",
			"Jupiter",
			"Neptune",
			"Argon",
			"Pluto",
			"Thor",
			"Ytinginly"
		};
		
		public Planet (String name) {
			this.name = name;
		}
		
		public String getName() {
			return name;
		}
		
		public void setLocation(Vector3 location) {
			this.location = location;
		}
	}
}

