using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    internal object onClick;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeButtonColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.gray; //按鍵按下後，改變一下顏色
        //Thread.Sleep(1);
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
    public void ChangeButtonColor_yellow()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
