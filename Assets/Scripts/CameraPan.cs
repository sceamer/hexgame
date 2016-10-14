using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	public float speed = 1f;

	void Update(){
		
	float xAxisValue = Input.GetAxis("Horizontal");
	float zAxisValue = Input.GetAxis("Vertical");
	float yAxisValue = Input.GetAxis("Mouse ScrollWheel");

		this.transform.Translate(new Vector3(xAxisValue*speed, zAxisValue*speed, yAxisValue*speed));

	}

}
