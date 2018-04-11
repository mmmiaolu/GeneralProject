using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2_HeroMove : MonoBehaviour {
	private GameObject hero1;
	private GameObject hero2;
	private Vector3 centerPoint; 
	private float radiusLength;
	private bool direction;
	private float tempAngle;
	// Use this for initialization
	void Start () {
		direction = true;
		tempAngle = 0;
		hero1 = GameObject.Find("two_star1");
		hero2 = GameObject.Find("two_star2");
		centerPoint = (hero1.transform.position + hero2.transform.position)/2;
		radiusLength = (hero2.transform.position.x - hero1.transform.position.x)/2;
	}
	
	// Update is called once per frame
	void Update () {
		rotate(direction, Time.deltaTime);
	}

	void rotate (bool direction, float deltaTime){
		Vector3 tempPosition = new Vector3();
		int direct = direction?1:-1;
		tempAngle = direct * deltaTime + tempAngle;
		tempPosition.x = centerPoint.x + Mathf.Cos(tempAngle) * radiusLength;
		tempPosition.y = centerPoint.y + Mathf.Sin(tempAngle) * radiusLength;
		tempPosition.z = 0;
		hero1.transform.position = tempPosition;
		Debug.Log(tempPosition);
	}
}
