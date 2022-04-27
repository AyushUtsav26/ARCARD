using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ytube()
    {
        Application.OpenURL("https://www.youtube.com/");
    }
    public void git()
    {
        Application.OpenURL("https://github.com");
    }
    public void mail()
    {
        Application.OpenURL("https://mail.google.com");
    }

}
