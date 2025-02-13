using UnityEngine;

public class AspectRatioScaler : MonoBehaviour
{
    public Renderer quadRenderer;  // Reference to the Renderer of the Quad
    public Texture2D imageTexture; // Reference to the texture applied to the Quad

    void Start()
    {
        // Ensure that the quad's scale is based on the image's aspect ratio
        if (quadRenderer != null && imageTexture != null)
        {
            // Get the width and height of the image
            float imageWidth = imageTexture.width;
            float imageHeight = imageTexture.height;

            // Calculate the aspect ratio
            float aspectRatio = imageWidth / imageHeight;

            // Adjust the scale of the quad based on the aspect ratio
            quadRenderer.transform.localScale = new Vector3(aspectRatio, 1, 1);
        }
    }
}

