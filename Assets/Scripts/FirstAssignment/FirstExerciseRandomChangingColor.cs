using UnityEngine;

public class FirstExerciseRandomChangingColor : MonoBehaviour
{
    private int current_frame = 0;
    public int amount_of_frames = 120;
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
        ++current_frame;
        if (current_frame == amount_of_frames) 
        {
            Vector3 random_color = new Vector3(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = new Color(random_color.x, random_color.y, random_color.z);
            current_frame = 0;
        }
    }
}
