using UnityEngine;

public class DispDepth : MonoBehaviour {
    public Material mat;
    void Start () 
    {
        GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
    }

    public void OnRenderImage(RenderTexture source, RenderTexture dest)
    {                
        Graphics.Blit(source, dest, mat);
    }
}