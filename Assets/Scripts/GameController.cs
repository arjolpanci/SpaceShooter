using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] asteroids;
    private List<GameObject> spawnedAsteroids = new List<GameObject>();
    private List<GameObject> destroyedAsteroids = new List<GameObject>();
    float timePassed = 0.0F;
    int seconds = 0;

    private System.Random rnd;

    void Start()
    {
        rnd = new System.Random();
    }

    void Update()
    {
        
        timePassed += Time.deltaTime;
        seconds = (int)timePassed % 60;

        if(seconds == 2){
            timePassed = 0;
            seconds = 0;

            int asteroidType = rnd.Next(0, asteroids.Length);
            int xPos = rnd.Next(-5, 5);
            //Instantiate(asteroids[asteroidType], new Vector3(xPos, 3.6F ,0), Quaternion.identity);

            GameObject newAsteroid = Instantiate(asteroids[asteroidType], new Vector3(xPos, 3.6F ,0), Quaternion.identity);
            spawnedAsteroids.Add(newAsteroid);
        }

        foreach(GameObject asteroid in spawnedAsteroids){
            if(asteroid != null){
                asteroid.transform.position += new Vector3(0, -0.01F, 0);
                if(asteroid.transform.position.y < -3.5F){
                    Destroy(asteroid);
                    destroyedAsteroids.Add(asteroid);
                }
            }
        }

        foreach(GameObject asteroid in destroyedAsteroids){
            if(asteroid != null){
                spawnedAsteroids.Remove(asteroid);
            }
        }

    }
}
