/* Matt Strayer */

using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	
	public double fuel = 100.00;
	public int bank = 10000;
	public int cargo_size = 5000;
	public item[] items;

	
	
	// Use this for initialization
	void Start () {
		item[0] = new item("Lightsabers",500);
		item[1] = new item("Blasters",1000);
		item[2] = new item("Dippin Dots", 500);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
}
