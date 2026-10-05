using UnityEngine;

public class NinthExerciseMovementWithKeysAndSpeed : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveIfArrowPressed();
    }

    /**
     * Moves the object in the direction of movement_direction if any of the arrow keys are pressed.
     */
    private void MoveIfArrowPressed()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movementDirection  = new Vector3(horizontalMovement, 0, verticalMovement);
        transform.Translate(movementDirection * speed);
    }
}
