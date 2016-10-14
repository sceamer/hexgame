using UnityEngine;
using System.Collections;

public class MapController : MonoBehaviour {

	public GameObject dirtTerrain;
	public int rows = 3;
	public int columns = 3;
	Vector3 position = new Vector3(1,1,-1f);
	public float distanceModifierX = 1f;
	public float distanceModifierY = 1f;


	// Use this for initialization
	void Start () {

		for(int i=0; i<rows;i++){
			for (int j = 0; j < columns; j++) {
				if ((i+j)%2==1) {
					Instantiate (dirtTerrain,
						new Vector3(position.x*i*distanceModifierX, position.x*j*distanceModifierY, position.z), Quaternion.identity);
				}
			}
	
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
