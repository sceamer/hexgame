using UnityEngine;
using System.Collections;

public class SelectTile : MonoBehaviour {

	Material selfMaterial;
	GameObject target;
	public GameObject selection;


	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{


			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				target = hitInfo.transform.gameObject;
				selection.transform.position = target.transform.position;


			} 
		} 
	}

}
