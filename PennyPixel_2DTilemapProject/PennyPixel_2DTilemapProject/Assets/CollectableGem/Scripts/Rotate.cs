/*
* Name: John Chirayil
* File: Rotate.cs
* CGE401 - Assignment 5A 
* Description: Allows the gem to rotate in position.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float speed = 5;
	public Vector3 rotateDirection;

	void Update(){
		transform.Rotate (rotateDirection * speed * Time.deltaTime);
	}
}
