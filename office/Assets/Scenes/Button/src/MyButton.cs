using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    internal object onClick;
    public Lock Lock;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter(Collision aaa)
    {
        Lock.ClickButton(this, int.Parse(this.gameObject.name.Substring("Button_".Length)));
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
