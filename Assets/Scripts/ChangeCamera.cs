using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera[] cameras;
    public int cameraID = 0;
    
    public void ChangeActiveCamera(int value)
    {
        cameras[cameraID].depth = 0;
        cameras[value].depth = 1;
        cameraID = value;
    }
}
