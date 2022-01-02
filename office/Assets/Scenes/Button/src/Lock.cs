using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public int buttonAmount = 10;
    public int sevenSegmentAmount = 3;
    public MyButton[] numberButton = new MyButton[10];
    public EnterButton enterButton;
    public ClearButton clearButton;
    public SevenSegment[] seven = new SevenSegment[3];

    public int[] answerNumber = new int[10];
    public GameObject artWork;
    public GameObject letter;
    //public GameObject circlePlan;
    private int[] clickedButtonNumber = new int[10];
    private int clickedButtonNumber_index = 0;
    private bool answerCorrect = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach(MyButton btn in numberButton){
            btn.Lock = this;
        }
        letter.SetActive(false);
        //circlePlan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (answerCorrect == false && clickedButtonNumber_index != sevenSegmentAmount)
        //{
        //    KeyCode[] ks = { KeyCode.Alpha0, KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha0, KeyCode.Alpha0, KeyCode.Alpha0, KeyCode.Alpha0 };
        //    for(int i = 0;i < 10; i++)
        //    {
        //        if (Input.GetKeyDown(ks[i]))
        //        {
        //            ClickButton(numberButton[i], i);
        //        }
        //    }


        //    if (Input.GetKeyDown(KeyCode.Alpha0)) { ClickButton(numberButton[0], 0); } // Input number 0
        //    if (Input.GetKeyDown(KeyCode.Alpha1)) { ClickButton(numberButton[1], 1); } // Input number 1
        //    if (Input.GetKeyDown(KeyCode.Alpha2)) { ClickButton(numberButton[2], 2); } // Input number 2
        //    if (Input.GetKeyDown(KeyCode.Alpha3)) { ClickButton(numberButton[3], 3); } // Input number 3
        //    if (Input.GetKeyDown(KeyCode.Alpha4)) { ClickButton(numberButton[4], 4); } // Input number 4
        //    if (Input.GetKeyDown(KeyCode.Alpha5)) { ClickButton(numberButton[5], 5); } // Input number 5
        //    if (Input.GetKeyDown(KeyCode.Alpha6)) { ClickButton(numberButton[6], 6); } // Input number 6
        //    if (Input.GetKeyDown(KeyCode.Alpha7)) { ClickButton(numberButton[7], 7); } // Input number 7
        //    if (Input.GetKeyDown(KeyCode.Alpha8)) { ClickButton(numberButton[8], 8); } // Input number 8
        //    if (Input.GetKeyDown(KeyCode.Alpha9)) { ClickButton(numberButton[9], 9); } // Input number 9
        //}
        //else if (answerCorrect == false && clickedButtonNumber_index == sevenSegmentAmount)
        //{
        //    if (Input.GetKeyDown(KeyCode.Delete))
        //    {
        //        SegmentRefresh();
        //        clickedButtonNumber_index = 0;
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.Return)) { checkAnswer(); }
    }
    public void ClickButton(MyButton NbButton, int n)
    {
        if(answerCorrect == false && clickedButtonNumber_index != sevenSegmentAmount)
        {
            clickedButtonNumber[clickedButtonNumber_index] = n;
            NbButton.ChangeButtonColor();
            seven[clickedButtonNumber_index].SetSegment(n);
            clickedButtonNumber_index += 1;
        }
    }

    /*
    void ClickButton(GameObject NbButton, int n)
    {
        clickedButtonNumber[clickedButtonNumber_index] = n;
        //NbButton.ChangeButtonColor();

        NbButton.GetComponent<MeshRenderer>().material.color = Color.gray; //按鍵按下後，改變一下顏色
        //Thread.Sleep(1);
        NbButton.GetComponent<MeshRenderer>().material.color = Color.white;
        seven[clickedButtonNumber_index].SetSegment(n);
        clickedButtonNumber_index += 1;
    }*/

    public void SegmentRefresh()
    {
        for (int i = 0; i < seven.Length; i++)
        {
            seven[i].SetSegment(-1);
        }
        clickedButtonNumber_index = 0;
    }

    public void checkAnswer()
    {
        answerCorrect = true;
        //按數字鍵1時，變更material顏色
        //紀錄按過的數字
        for (int i = 0; i < sevenSegmentAmount; i++)
        {
            if (answerNumber[i] != clickedButtonNumber[i])
            {
                answerCorrect = false;
                break;
            }
        }

        if (answerCorrect == true)
        {

            for (int i = 0; i < buttonAmount; i++)
            {
                numberButton[i].ChangeButtonColor_yellow();
            }

            float step = 10 * Time.deltaTime;
            artWork.transform.localPosition = Vector3.MoveTowards(artWork.transform.localPosition, new Vector3(0, 0, 0), step);
            //circlePlan.SetActive(true);
            letter.SetActive(true);
            //artWork.transform.position = new Vector3(artWork.transform.position.x, artWork.transform.localPosition.y + 0.096, artWork.transform.position.z);
            //enterButton.ChangeButtonColor_yellow();
            //clearButton.ChangeButtonColor_yellow();
        }
        else
        {
            SegmentRefresh();
        }
        clickedButtonNumber_index = 0;
    }
}
