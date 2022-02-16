using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    //Gameobjects
    public GameObject projectile;
    public GameObject projectileSpawnPoint;
    public GameObject pivotPoint;
    // GameObject projectile, projectileSpawnPoint, pivotPoint ;

    // float is a a number with deciamls
    public float angle;
    public float projectilePower = 5.0f;
    //public float angle, projectilePower;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Capture Mouse Poistion
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - pivotPoint.transform.position;

        //Calculate the angle Based on the mouse Postion
        angle = Mathf.Atan2(mousePos.x, mousePos.y) * Mathf.Rad2Deg;
        if (angle < 98 && angle > -98)
        {
            pivotPoint.transform.rotation = Quaternion.Euler(0, 0, -angle);
        }

        //Update the Platform Rotation 
        // Log a Keyboard Press
        if (Input.GetKeyDown(KeyCode.Space))
            {
            Debug.Log("Space key was pressed.");
            //Calculate the Velocity
            Vector2 velocity = new Vector2(projectilePower * Mathf.Sin(angle * Mathf.Deg2Rad), projectilePower * Mathf.Cos(angle * Mathf.Deg2Rad));
            //Spawn the Projectile at the Spawn Point.
            GameObject spawnedProjectile = Instantiate(projectile, projectileSpawnPoint.transform.position, Quaternion.identity);

            //Get access to the Rigid Body
            Rigidbody2D rb = spawnedProjectile.GetComponent<Rigidbody2D>();

            //Apply The Velocity to the Rigid Body
            rb.position = projectileSpawnPoint.transform.position;
            rb.velocity = velocity;
        };
           

       
    }
  
}  


  
   
    
        

