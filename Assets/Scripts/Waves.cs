using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject prefabAsteroid;
    public int Asteroids = 3;

    void Start()
    {
        for(int i = 0; i < Asteroids; i++) {
            float dirY = Random.Range(-4.0f, 2.0f);
            float dirX = Random.Range(4.0f, -2.0f);
            
            Vector3 position = new Vector3(dirX, dirY, 0.0f);

            Instantiate(prefabAsteroid, position, Quaternion.identity);
        }
    }
}