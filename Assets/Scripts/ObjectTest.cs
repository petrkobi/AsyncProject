using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTest : MonoBehaviour {

	private object i_obj = 100;
	private object f_obj = 100.0f;

	// Use this for initialization
	void Start () {
		Debug.Log (i_obj.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.T))
		{
			
			int i = 0;
			float f = 0;
			Debug.Log (i_obj.GetType ());

			i = (int)i_obj;
			Debug.Log (i);

			f = (float)f_obj;
			Debug.Log (f);
		}
	}
}
