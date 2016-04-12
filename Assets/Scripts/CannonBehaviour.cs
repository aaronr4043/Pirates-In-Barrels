using UnityEngine;
using System.Collections;

public class CannonBehaviour : MonoBehaviour
{
    public Transform target;
    int upgradeState;
    GameObject prefab;
    float timer;
    float globalTimer;
    bool shipDetected;
    GameObject thisCannon;
    public int cost = 250;
    //Vector3 offset = new Vector3(0, 40, 137);
    void Start()
    {
        prefab = Resources.Load("cannonball") as GameObject;
        timer = 0;
        shipDetected = false;
        globalTimer = 0.0f;
    }

    

    void Update()
    {
        globalTimer += Time.deltaTime;
        timer += Time.deltaTime;
        
        globalTimer = 0.0f;
        if (PathFollowing.enemies.Count != 0)
        {
            foreach (GameObject enemy in PathFollowing.enemies)
            {
                
                if (enemy != null)
                {
                    if(enemy.tag=="Enemy")
                    if (Vector3.Distance(transform.position, enemy.transform.position) < 90)
                    {
                            transform.LookAt(enemy.transform);

                            //transform.right = (target.position - transform.position);
                            if (timer > 3.5f)
                            {
                            timer = 0.0f;
                            GameObject projectile = Instantiate(prefab) as GameObject;
                            projectile.transform.position = transform.position + this.transform.forward * 2;

                            Rigidbody rb = projectile.GetComponent<Rigidbody>();
                            rb.velocity = this.transform.forward * 120;

                        }

                    }//end if
                }

            }//end for each 
        }

        
        
    }
    
}