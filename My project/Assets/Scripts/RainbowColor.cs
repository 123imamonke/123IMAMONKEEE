using System.Collections;
using UnityEngine;
using Photon.VR;
public class RainbowColor : MonoBehaviour
{
    // Color keys for the rainbow gradient
    private readonly Color[] rainbowColors =
    {
        Color.red,
        Color.yellow,
        Color.green,
        Color.blue,
        new Color(75f / 255f, 0, 130f / 255f),
        new Color(148f / 255f, 0, 211f / 255f)
    };

    // Time to transition between colors
    public float transitionTime = 2.0f;

    // Timer for transitioning between colors
    private float timer;

    // Color variable to change
    public Color color;

    void Start()
    {
        // Initialize the timer
        timer = 0;
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Calculate the progress through the transition
        float progress = timer / transitionTime;

        // Calculate the current color based on the progress through the gradient
        color = GetRainbowColor(progress);

        Color myColour = color;
        PhotonVRManager.SetColour(myColour);


        // Reset the timer if it has exceeded the transition time
        if (timer >= transitionTime)
        {
            timer -= transitionTime;
        }
    }

    // Calculate the color of the rainbow at a specific progress value
    Color GetRainbowColor(float progress)
    {
        // Calculate the index of the current color in the rainbowColors array
        int colorIndex = (int)(progress * rainbowColors.Length);

        // Wrap the color index around if it exceeds the length of the array
        colorIndex = colorIndex % rainbowColors.Length;

        // Calculate the progress through the transition between the current and next colors
        float t = progress * rainbowColors.Length - colorIndex;

        // Interpolate between the current and next colors based on the transition progress
        Color color = Color.Lerp(rainbowColors[colorIndex], rainbowColors[(colorIndex + 1) % rainbowColors.Length], t);

        return color;
    }
}
