using UnityEngine;

public class FifthExerciseLinealMovementSpaceBar : MonoBehaviour
{
    public Vector3 movement_direction = new Vector3(1.0f, 1.0f, 1.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveIfSpaceBarPressed();
    }

    /**
     * Moves the object in the direction of movement_direction if the space bar is pressed.
     */
    private void MoveIfSpaceBarPressed()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            transform.position += movement_direction;
        }
    }
}
