using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text fpsText; // For UI Text
    public TextMeshProUGUI tmpText; // For TextMeshPro

    private float deltaTime = 0.0f;

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        string fpsDisplay = "FPS: " + Mathf.Round(fps);

        if (fpsText != null)
            fpsText.text = fpsDisplay;
        if (tmpText != null)
            tmpText.text = fpsDisplay;
    }
}
