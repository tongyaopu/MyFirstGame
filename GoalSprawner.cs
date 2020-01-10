
using UnityEngine;

public class GoalSprawner : MonoBehaviour
{
    public GameObject GoalPrefab;
    public Transform player;
    private int FixedY = 1; // fix the upcoming obstacle in y plane
    private int FixedZ = 490;


    void Start()
    {
        sprawnGoal(); 
    }
    void sprawnGoal()
    {
 
            // randomnize the emergence place of the goal
            int RandomX = Random.Range(-7, 7); // position in x
            Vector3 pos = new Vector3(RandomX, FixedY, FixedZ);   // position
            GameObject point = Instantiate(GoalPrefab);    // initiate obstacle
            point.transform.position = pos;    //goal position


    }
}
