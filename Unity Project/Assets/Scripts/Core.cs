using UnityEngine;
using System.Collections;

public class Core : MonoBehaviour {

	// Use this for initialization
	public Transform Target;
	private NavMeshAgent Agent;
	public Vector2 Radios;
	public Vector2 Speeds;
	public Material[] mat;



	void Start () {

		//GetComponent<NavMeshAgent>().SetDestination(Target.position);
		Agent=GetComponent<NavMeshAgent>();

		RandomeRadius();
		//RandomeSpeed();
		//RandomeRadiusWithRelatedSpeed();
	//	ReverseRandomeRadiusWithRelatedSpeed();

	}
	
	// Update is called once per frame
	void Update () {
		Agent.SetDestination(Target.position); // It is clear that what to do
	}

	void RandomeRadius()

	{
		float A= Random.Range ( Speeds.x, Speeds.y) ; 
		Agent.speed=A;
        float dis = Radios.y - Radios.x;
        float dis2 = Speeds.y - Speeds.x;

		// Creating MAterials
		
        if (A >= 0 && A < Speeds.x + 0.25 * dis2)
        {
            renderer.material = mat[0];

          //  Agent.speed = Random.Range(Speeds.x + 0.75f * dis2, Speeds.x + 1f * dis2);
          //  Agent.avoidancePriority = Random.Range(75, 99);
            //
        }
        else if (A >= Speeds.x + 0.25 * dis2 && A < Speeds.x + 0.5 * dis2)
        {
            renderer.material = mat[1];
         //   Agent.speed = Random.Range(Speeds.x + 0.5f * dis2, Speeds.x + 0.75f * dis2);
           // Agent.avoidancePriority = Random.Range(50, 75);
        }
        else if (A >= Speeds.x + 0.5 * dis2 && A < Speeds.x + 0.75 * dis2)
        {
            renderer.material = mat[2];
          //  Agent.speed = Random.Range(Speeds.x + 0.25f * dis2, Speeds.x + 0.5f * dis2);
           // Agent.avoidancePriority = Random.Range(25, 50);
        }
        else
        {
            renderer.material = mat[3];
            
          //  Agent.speed = Random.Range(Speeds.x, Speeds.x + 0.25f * dis2);
            
          
           // Agent.avoidancePriority = Random.Range(0, 25);
        }
	}

	void RandomeSpeed()
	{
		float A= Random.Range ( Speeds.x, Speeds.y) ; 
		Agent.speed=A;
	}
	void RandomeRadiusWithRelatedSpeed()
	{
		float A= Random.Range ( Radios.x, Radios.y) ; 
		Agent.radius=A;
		
		if ( A>=0.5 && A<0.75) 
		{
			renderer.material=mat[0];
			Agent.speed=Random.Range(8.75f,10);
		}
		else if ( A>=0.75 && A<1) 
		{
			renderer.material=mat[1];
			Agent.speed=Random.Range(7.5f,8.75f);
		}
		else if ( A>=1 && A<1.25) 
		{
			renderer.material=mat[2];
			Agent.speed=Random.Range(6.25f,7.5f);
		}
		else 
		{
			renderer.material=mat[3];
			Agent.speed=Random.Range(5f,6.25f);
		}
	}
	void ReverseRandomeRadiusWithRelatedSpeed()
	{
		float A= Random.Range ( Radios.x, Radios.y) ; 
		Agent.radius=A;
		
		if ( A>=0.5 && A<0.75) 
		{
			renderer.material=mat[0];
			Agent.speed=Random.Range(5f,6.25f);

		}
		else if ( A>=0.75 && A<1) 
		{
			renderer.material=mat[1];
			Agent.speed=Random.Range(6.25f,7.5f);
		
		}
		else if ( A>=1 && A<1.25) 
		{
			renderer.material=mat[2];
			Agent.speed=Random.Range(7.5f,8.75f);
		}
		else 
		{
			renderer.material=mat[3];
			Agent.speed=Random.Range(8.75f,10);
		}
	}
}
