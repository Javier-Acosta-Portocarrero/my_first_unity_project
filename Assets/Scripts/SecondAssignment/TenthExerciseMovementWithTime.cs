using UnityEngine;

public class TenthExerciseMovementWithTime : MonoBehaviour
{
    public float speed = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveIfArrowPressedWithDeltaTime();
    }

    /**
     * Moves the object in the direction of movement_direction if any of the arrow keys are pressed,
     * taking into account the time elapsed since the last frame.
     */
    private void MoveIfArrowPressedWithDeltaTime()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movementDirection  = new Vector3(horizontalMovement, 0, verticalMovement);
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
