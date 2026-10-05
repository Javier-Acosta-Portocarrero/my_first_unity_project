using UnityEngine;

public class TwelfthExerciseLookAtTarget : MonoBehaviour
{
    public float speed = 1.0f;
    public string targetTag = "golden_sphere";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsTargetWhileLookingAtIt();
    }

    /**
     * Moves the object towards the target with the specified tag while looking at it.
     */
    private void MoveTowardsTargetWhileLookingAtIt()
    {
        GameObject target = GameObject.FindWithTag(targetTag);
        if (target == null)
        {
            return;
        }
        transform.LookAt(target.transform);

        Vector3 movementDirection = target.transform.position - transform.position;  // Vector with the distance
        transform.Translate(movementDirection.normalized * speed * Time.deltaTime, Space.World);  // Use movement relative to the world.
    }
}
