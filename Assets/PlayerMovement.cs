using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	float moveSpeed = 10f;
	
	Rigidbody body;
	
	public Light greenLight;
	public Light blueLight;
	public Light redLight;
	public Light yellowLight;

	void Start ()
	{
		body = GetComponent<Rigidbody>();
		
		string[] names = Input.GetJoystickNames();
		for (int i=0; i != names.Length; ++i)
		{
			string name = names[i];
			Debug.Log ("controller " + i + " named " + name);
		}
	}

	void FixedUpdate ()
	{
		float x = Input.GetAxis("HorizontalMovement");
		float y = Input.GetAxis("VerticalMovement");
		
//		if ((0 != x) || (0 != y)) {
//			Debug.Log("v " + x + "," + y);
//		}
		
		body.velocity = new Vector3(x, 0, y) * moveSpeed;
		
		float lookX = Input.GetAxis("HorizontalRotation");
		float lookY = Input.GetAxis("VerticalRotation");
		
		if ((0 != lookX) || (0 != lookY))
			body.rotation = Quaternion.LookRotation(new Vector3(lookX, 0, lookY));
		
		ResetLights();
		
		for (int i=0; i!=13; ++i)
		{
			string buttonName = "j1b" + i;
			
			if (Input.GetButton(buttonName)) {
				Debug.Log (buttonName);
				
				SwitchColor(i);
			}
		}
		
		for (int i=0; i!=2; ++i)
			for (int j=0; j!=3; ++j)
				CheckAxis("j1" + ((0 == i) ? "x" : "y") + (j + 1));
	}
	
	void CheckAxis(string name)
	{
		float f = Input.GetAxis(name);
		if (f > 0) {
			Debug.Log (name + " " + f);
		}
	}
	
	void ResetLights()
	{
		greenLight.intensity = 0;
		blueLight.intensity = 0;
		yellowLight.intensity = 0;
		redLight.intensity = 0;
	}
	
	void SwitchColor(int i)
	{
		Light light;
		
		switch (i)
		{
			case 3:								// A
				light = greenLight;
				Debug.Log ("green");
				break;
			case 4:								// B
				light = redLight;
				Debug.Log ("red");
				break;
			case 5:								// X
				light = blueLight;
				Debug.Log ("blue");
				break;
			case 6:								// Y
				light = yellowLight;
				Debug.Log ("yellow");
				break;
			default:
				light = null;
				break;
		}
		
		if (null != light)
			light.intensity = 8;
		
	}
}
