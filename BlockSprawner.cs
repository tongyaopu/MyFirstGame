
using UnityEngine;

public class BlockSprawner : MonoBehaviour
{

    public GameObject ObstaclePrefab;
    public Transform player;
    private int FixedY = 1; // fix the upcoming obstacle in y plane
    private float timeToSprawn = 2f;
    private float timeBetween = 5f;
    void   if (Time.time >= timeToSprawn)
        {
            sprawnEnemy();
     }
        
    }

    void sprawnEnemy ()
    {
        if (player.position.z <= 440)
        {

            int RandomX = Random.Range(-6, 6); 40n in x
            int aheadValuould be ahead of the player
            int RandomZ = (int)(player.position.z + aheadValue); // z position ahead of player
            Vector3 pos = new Vector3(RandomX, FixedY, RandomZ);   // position
            GameObject ob = Instantiate(ObstaclePrefab);    // initiate obstacle
            ob.transform.position = pos;    //obstacle position
        }
        
    }

}
