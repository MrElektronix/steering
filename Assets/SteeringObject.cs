using UnityEngine;
using System.Collections;

public class SteeringObject : MonoBehaviour {

    public Transform target;
    private float maxSpeed = 15;
    private float mass = 20;

    private Vector3 position = new Vector3();
    private Vector3 velocity = new Vector3(2, 0, 0);
    
   void Start()
    {
        //velocity *= maxSpeed;
    }

   void Update()
    {
        Seek();
    }

    void Seek()
    {
        Vector3 desiredStep = target.position - transform.position;
        Debug.DrawLine(target.position, transform.position);
        desiredStep.Normalize();

        Vector3 desiredVelocity = desiredStep * maxSpeed;
        Vector3 steeringForce = desiredVelocity - velocity;

        velocity += (steeringForce / mass);

        position += (velocity * Time.deltaTime);
        transform.position = position;
    }
}
