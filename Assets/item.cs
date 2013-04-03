/* Matt Strayer */

using System.Collections;

public class item{
	// name of the cargo item
	private string name;
	private int space_used;
	private double itemValue;
	
	 public item(string n,int x)
    {
        name = n;
		space_used = x;
    }
	
	public void setName(string n)
	{
		name = n;
	}
	public void setSpaceUsed(int x)
	{
		space_used = x;	
	}
	public void setItemValue(double v)
	{
		itemValue = v;	
	}
	
	public double getValue(string s, int x)
	{
	
		if(s == "Lightsabers")
		{
			return x * 1.5;	
		}
		if(s == "Blasters")
		{
			return x * 1.0;
		}
		if(s == "Dippin Dots")
		{
			return x * 	0.5;
		}
		if(s == "Spare Parts")
		{
			return x * 0.9;	
		}
		
	}
}
