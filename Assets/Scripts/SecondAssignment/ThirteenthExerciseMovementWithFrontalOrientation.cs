using UnityEngine;

public class ThirteenthExerciseMovementWithFrontalOrientation : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveWhileRotating();
        DrawDebugRay();
    }

    /**
     * Moves the object forward while allowing it to rotate left or right based on horizontal input.
     */
    private void MoveWhileRotating()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        // Rotate to the left or the right
        transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
        // Advance forward
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    /**
     * Draws a debug ray in the forward direction of the object.
     */
    private void DrawDebugRay()
    {
        Debug.DrawRay(transform.position, transform.forward * 3, Color.red);
    }
}
