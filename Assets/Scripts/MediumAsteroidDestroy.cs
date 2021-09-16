using UnityEngine;

public class MediumAsteroidDestroy : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float maxSpeed = 1.0f;
    public GameObject smallAsteroid;

    void Start()
    {
        Vector2 direction = Random.insideUnitCircle;
        direction *= maxSpeed;
        myRigidBody.velocity = direction;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Instantiate(smallAsteroid, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
