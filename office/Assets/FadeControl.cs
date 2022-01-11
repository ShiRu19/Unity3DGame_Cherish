using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class FadeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        			SteamVR_Fade.Start(Color.black, 0);
        			SteamVR_Fade.Start(Color.clear, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
