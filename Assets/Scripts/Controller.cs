using UnityEngine;

public class Controller : MonoBehaviour
{
    //Bydo, quando você ler isso aqui daqui uns meses, dá uma risada kkkk

    ChangeCamera changeCamera;
    public GameObject[] cameraChecks;

    void Start()
    {
        changeCamera = GetComponent<ChangeCamera>();
    }

    public void ChangeActiveCamera(int value)
    {
        foreach(GameObject c in cameraChecks) c.SetActive(false);
        if(value>0) cameraChecks[value-1].SetActive(true);
        changeCamera.ChangeActiveCamera(value);
    }
}
