using UnityEngine;

public class flashlightcontroller : MonoBehaviour
{
    public bool status = false;
    public GameObject light;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && status == false) {
            light.SetActive(true);
            status = true;
        } else if(Input.GetKeyDown(KeyCode.F) && status == true) {
            light.SetActive(false);
            status = false;
        }
    }
}
