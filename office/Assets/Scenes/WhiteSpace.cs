using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))//���s���J�ثe����
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        Application.LoadLevel(1);
        if (Input.GetKeyDown(KeyCode.M))//��������
        {
            //�[������
            SceneManager.LoadScene(1);
            //��o��e����
            //Scene scene = SceneManager.GetActiveScene();
            //���s�[����e����
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            /*if (Application.loadedLevel == 0)
                    Application.LoadLevel(1);
                else
                    Application.LoadLevel(0);*/
        }
    }
}
