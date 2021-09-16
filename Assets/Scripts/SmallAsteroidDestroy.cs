using UnityEngine;

public class SmallAsteroidDestroy : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float maxSpeed = 1.0f;

    void Start()
    {
        Vector2 direction = Random.insideUnitCircle;
        direction *= maxSpeed;
        myRigidBody.velocity = direction;
    }
    
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(gameObject);
    }
}
