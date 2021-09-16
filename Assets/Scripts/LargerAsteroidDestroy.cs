using UnityEngine;

public class LargerAsteroidDestroy : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float maxSpeed = 1.0f;
    public GameObject mediumAsteroid;

    void Start()
    {
        Vector2 direction = Random.insideUnitCircle;
        direction *= maxSpeed;
        myRigidBody.velocity = direction;
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Instantiate(mediumAsteroid, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
