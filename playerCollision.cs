
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public  playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Goal")
        {
            movement.enabled = false;
        }

        if (collisionInfo.collider.tag == "Point")
        {
            //ContactPoint contact = collision.contacts[0];
            //Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = collisionInfo.collider.ClosestPointOnBounds;
            Instantiate(plasmaPrefab, position);
            Collider points1 = points;
            Destroy(points1);
        }
    }
}
