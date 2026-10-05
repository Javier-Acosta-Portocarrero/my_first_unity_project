using UnityEngine;

public class EigthExerciseMovementsWithSpeedByFrame : MonoBehaviour
{
    public Vector3 movement_direction = new Vector3(1.0f, 1.0f, 1.0f);
    public float speed = 1.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement_direction[0] * speed, movement_direction[1] * speed, movement_direction[2] * speed);
    }
}
