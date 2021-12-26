using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton2 : MonoBehaviour
{
    public Lock2 Lock2;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter(Collision aaa)
    {
        if(this.gameObject.name == "EnterButton")
        {
            Lock2.checkAnswer();
        }else if(this.gameObject.name == "ClearButton")
        {
            Lock2.SegmentRefresh();
        }
        else
        {
            Lock2.ClickButton(this, int.Parse(this.gameObject.name.Substring("Button_".Length)));
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeButtonColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.gray; //������U��A���ܤ@�U�C��
        //Thread.Sleep(1);
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
    public void ChangeButtonColor_yellow()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
