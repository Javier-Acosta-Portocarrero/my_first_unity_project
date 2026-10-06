using UnityEngine;

public class EleventhMovementTowardsTarget : MonoBehaviour
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
        MoveTowardsTarget();
    }

    /**
     * Moves the object towards the target with the specified tag.
     */
    private void MoveTowardsTarget()
    {
        Vector3 movementDirection = GameObject.FindWithTag(targetTag).transform.position - transform.position;  // Vector with the distance to the target.
        movementDirection[1] = 0;  // Ignore the Y axis to avoid moving up or down
        transform.Translate(movementDirection.normalized * speed * Time.deltaTime);
    }
}
