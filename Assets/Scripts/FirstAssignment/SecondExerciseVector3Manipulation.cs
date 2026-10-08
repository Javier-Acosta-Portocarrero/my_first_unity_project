using UnityEngine;

public class SecondExerciseVector3Manipulation : MonoBehaviour
{
    public Vector3 firstVector = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 secondVector = new Vector3(0.0f, 0.0f, 0.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateVector3Properties();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CalculateVector3Properties() 
    {
        Debug.Log("Exercise 2");
        Debug.Log("First vector " + firstVector + " magnitude: " + firstVector.magnitude);
        Debug.Log("Second vector " + secondVector + " magnitude: " + secondVector.magnitude);
        Debug.Log("Angle between both vectors  : " + Vector3.Angle(firstVector, secondVector) + " degrees");
        Debug.Log("Distance between both vectors: " + Vector3.Distance(firstVector, secondVector));
        Debug.Log("The vector with the most height is the " + (firstVector.y > secondVector.y ? "first ": "second ") + "one");
    }
}
