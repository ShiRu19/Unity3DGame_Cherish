using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject Cube;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
            Cube.SetActive(true); //�������
        else if (Input.GetKeyDown(KeyCode.H))
            Cube.SetActive(false); //��������

        if (Input.GetKeyDown(KeyCode.Y))
            Cube.GetComponent<MeshRenderer>().material.color = Color.yellow; //�����C��
        else if (Input.GetKeyDown(KeyCode.B))
            Cube.GetComponent<MeshRenderer>().material.color = Color.black;

        if (Input.GetKeyDown(KeyCode.M))
            SceneManager.LoadScene("BlackSpace"); //�[������

    }

    public void a()
    {

    }
}
