using UnityEngine;

public class FirstExerciseRandomChangingColor : MonoBehaviour
{
    private int currentFrame = 0;
    public int amountOfFrames = 120;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeRandomColorByFrames();
    }

    private void ChangeRandomColorByFrames() 
    {
        // Debug.Log("Current frame: " + current_frame);
        ++currentFrame;
        if (currentFrame == amountOfFrames) 
        {
            Vector3 random_color = new Vector3(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = new Color(random_color.x, random_color.y, random_color.z);
            currentFrame = 0;
        }
    }
}
