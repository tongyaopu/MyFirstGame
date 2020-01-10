
using UnityEngine;

public class PointSprawner : MonoBehaviour
{
    public GameObject PointPrefab;
    public Transform player;
    private int FixedY = 1; // fix the upcoming obstacle in y plane
    private float timeToSprawn = 2f;
    private float timeBetween = 0.5f;

    void Update()
    {
        if (Time.time >= timeToSprawn)
        {
            sprawnPoint();
            timeToSprawn = Time.time + timeBetween;
        }

    }

    void sprawnPoint()
    {
        if (player.position.z <= 440)
        {
            // randomnize the emergence place of the goal
            int RandomX = Random.Range(-7, 7); // position in x
            int aheadValue = Random.Range(38, 45); // the goal should be ahead of the player
            int RandomZ = (int)(player.position.z + aheadValue); // z position ahead of player
            Vector3 pos = new Vector3(RandomX, FixedY, RandomZ);   // position
            GameObject point = Instantiate(PointPrefab);    // initiate obstacle
            point.transform.position = pos;    //goal position
        }

    }
}
