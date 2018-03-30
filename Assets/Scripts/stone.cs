using UnityEngine;
using System.Collections;

public class stone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()  
	{  
		if(this.transform.position.z>=0)Destroy(this.gameObject);  
	}  
}
