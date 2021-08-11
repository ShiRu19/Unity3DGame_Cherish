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
        if (Input.GetKeyDown(KeyCode.R))//重新載入目前場景
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        Application.LoadLevel(1);
        if (Input.GetKeyDown(KeyCode.M))//切換場景
        {
            //加載場景
            SceneManager.LoadScene(1);
            //獲得當前場景
            //Scene scene = SceneManager.GetActiveScene();
            //重新加載當前場景
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            /*if (Application.loadedLevel == 0)
                    Application.LoadLevel(1);
                else
                    Application.LoadLevel(0);*/
        }
    }
}
