using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	// Use this for initialization


	
	public int Count;
	public Vector2 MinMaxX;
	public Vector2 MinMaxZ;
	
	public Transform Player;
	void Start () {
			
		RandomeLyGenerate();  /// Create Agent
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void RandomeLyGenerate() 
	{
		float y=transform.position.y;
		for ( int i=0 ; i < Count ; i++) 
		{
			Instantiate( Player , new Vector3 ( Random.Range(MinMaxX.x,MinMaxX.y),
			                                   y,
			                                   Random.Range(MinMaxZ.x,MinMaxZ.y)),Quaternion.identity);
		}
	}

}
