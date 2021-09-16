using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float acceleration = 1.0f;
    public float angularSpeed = 180f;
    public float maxSpeed = 10.0f;

    public Rigidbody2D prefabBullet;
    public float bulletSpeed = 10f;

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody2D Bullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
            Bullet.velocity = transform.right * bulletSpeed;
        }
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow)) {
            Vector3 direction = transform.right * acceleration;
            MyRigidBody.AddForce(direction, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            MyRigidBody.rotation += angularSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            MyRigidBody.rotation -= angularSpeed * Time.deltaTime;
        }

        if (MyRigidBody.velocity.magnitude > maxSpeed) {
            MyRigidBody.velocity = Vector2.ClampMagnitude(MyRigidBody.velocity, maxSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(gameObject);
    }
}
