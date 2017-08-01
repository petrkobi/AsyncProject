using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsyncTest : MonoBehaviour {
	public delegate void UpPointDelegate(bool isPointUp);
	public UpPointDelegate OnUpPointFinished;


	void Update()
	{
		//Debug.Log ("-update-");

		//Asynchronous call with delegate
		if (Input.GetKeyDown (KeyCode.E)) {
			Debug.Log("Press E -> ");
			OnUpPointFinished += UpPoint;
			StartCoroutine (AsyncCall ());
			Debug.Log ("After UpPoint");
		}
			

		//Synchonous call
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			Debug.Log("Press R -> ");
			UpPointSynchronous (true);
			Debug.Log ("After UpPointSynchronous");
		}
	}

	void UpPoint(bool success)
	{
		OnUpPointFinished -= UpPoint;
		if (success) 
		{
			Debug.Log (success);
		}
	}

	void UpPointSynchronous(bool success)
	{
		if (success) 
		{
			Debug.Log (success);
		}
	}

	private IEnumerator  AsyncCall()
	{
		yield return new WaitForSeconds (3.0f);
		if (OnUpPointFinished != null) 
		{
			UpPoint (true);
		}

	}
}
