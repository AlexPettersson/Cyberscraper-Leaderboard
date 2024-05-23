using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite ElOff; // Assign the first sprite in the Inspector
    public Sprite ElOn; // Assign the second sprite in the Inspector (Elon musk?!?!?!!)

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component attached to the GameObject
        UpdateSprite(); // Update the sprite initially
    }

    private void Update()
    {
        UpdateSprite(); // Update the sprite every frame (you can optimize this based on your needs)
    }

    private void UpdateSprite()
    {
        // Check the value of the variable and set the sprite accordingly
        if (LevelLoader.ElevatorStatus == false)
        {
            spriteRenderer.sprite = ElOff;
        }
        else if (LevelLoader.ElevatorStatus == true)
        {
            spriteRenderer.sprite = ElOn;
        }
    }
}
