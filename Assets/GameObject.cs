using UnityEngine;
using System.Collections;

public class GameObject : MonoBehaviour 
{

	public class Objects
	{
		public float speed; // Set this to 0 for towers
		public float x; // Co- Ords for each game object
		public float y;
		public float z;
		public float healthpoints; // initialise as 0 for Projectiles
        public float value = 0;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
