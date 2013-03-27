//This function will take a series of three coordinates and once every second the object will move closer
//to the input point by 1 in each direction

using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {
	
	public float x_goal;
	public float y_goal;
	public float z_goal;
	
	public float x_rate;
	public float y_rate;
	public float z_rate;
	public float time_rate;
	
	// Use this for initialization
	void Start () {
		 InvokeRepeating("Travel", 1, time_rate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Travel (){
		//store the current position into these three values, update them as needed
		float new_x = this.transform.position.x;
		float new_y = this.transform.position.y;
		float new_z = this.transform.position.z;

		if(transform.position.x > x_goal){//check if object has reached the x-goal 
			new_x= new_x - x_rate;
		}
		else if(transform.position.x < x_goal){
			new_x = new_x + x_rate;
		}
		
		if(transform.position.y > y_goal){ //check if object has reached the y-goal 
			new_y= new_y - y_rate;
		}
		else if(transform.position.y < y_goal){
			new_y = new_y + y_rate;
		}
		
		if(transform.position.z > z_goal){ //check if object has reached the z-goal 
			new_z = new_z - z_rate;
		}
		else if(transform.position.z < z_goal){
			new_z = new_z + z_rate;
		}
		
		transform.position = new Vector3(new_x, new_y, new_z);//update the position
		
		float encounter = Random.value;//generate random number
		if(encounter <= 0.5){
			transform.position = new Vector3(0, 0, 0);
		}
	}
}
