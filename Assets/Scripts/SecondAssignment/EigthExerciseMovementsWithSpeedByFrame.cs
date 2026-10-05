using UnityEngine;

public class EigthExerciseMovementsWithSpeedByFrame : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 1.0f, 1.0f);
    public float speed = 1.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection[0] * speed, moveDirection[1] * speed, moveDirection[2] * speed);
    }
}
