using UnityEngine;
using System.Collections;

public class Game2_block : MonoBehaviour {
	void Start () {
	}

	public float speed_down = (float)-2;

	// Update is called once per frame
	void Update () {
		Vector3 curpos = this.transform.position;
		curpos.y = curpos.y + speed_down * Time.deltaTime;
		this.transform.position = curpos;
	}

	void OnBecameInvisible()  
	{  
		if(this.transform.position.z>=0)Destroy(this.gameObject);  
	}  
}
