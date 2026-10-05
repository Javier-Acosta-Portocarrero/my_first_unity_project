using UnityEngine;

public class SixthExerciseKeySpeed : MonoBehaviour
{
    public float speed = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowMovementsIfArrowPressed();
    }
    
    /**
     * Shows the movement speed in the console if any of the arrow keys are pressed.
     */
    private void ShowMovementsIfArrowPressed()
    {
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow: " + speed * verticalMovement);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow: " + speed * verticalMovement);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow: " + speed * horizontalMovement);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left arrow: " + speed * horizontalMovement);
        }
    }

}
