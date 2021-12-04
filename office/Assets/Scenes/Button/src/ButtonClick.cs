using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ButtonClick : MonoBehaviour
{
    //public GameObject NumberButton_1;
    //public GameObject NumberButton_2;
    //public GameObject NumberButton_3;
    public int ButtonAmount;
    public int SevenSegmentAmount;
    public MyButton[] NumberButton = new MyButton[10];
    public MyButton EnterButton;
    public MyButton ClearButton;
    public SevenSegment[] seven = new SevenSegment[3];

    public int[] answerNumber = new int[10];
    private int[] clickedButtonNumber = new int[10];
    private int clickedButtonNumber_index = 0;
    private bool answerCorrect = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if(answerCorrect == false && clickedButtonNumber_index != SevenSegmentAmount)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0)) { ClickButton(NumberButton[0], 0); } // Input number 0
            if (Input.GetKeyDown(KeyCode.Alpha1)) { ClickButton(NumberButton[1], 1); } // Input number 1
            if (Input.GetKeyDown(KeyCode.Alpha2)) { ClickButton(NumberButton[2], 2); } // Input number 2
            if (Input.GetKeyDown(KeyCode.Alpha3)) { ClickButton(NumberButton[3], 3); } // Input number 3
            if (Input.GetKeyDown(KeyCode.Alpha4)) { ClickButton(NumberButton[4], 4); } // Input number 4
            if (Input.GetKeyDown(KeyCode.Alpha5)) { ClickButton(NumberButton[5], 5); } // Input number 5
            if (Input.GetKeyDown(KeyCode.Alpha6)) { ClickButton(NumberButton[6], 6); } // Input number 6
            if (Input.GetKeyDown(KeyCode.Alpha7)) { ClickButton(NumberButton[7], 7); } // Input number 7
            if (Input.GetKeyDown(KeyCode.Alpha8)) { ClickButton(NumberButton[8], 8); } // Input number 8
            if (Input.GetKeyDown(KeyCode.Alpha9)) { ClickButton(NumberButton[9], 9); } // Input number 9

            // CheckAnswer
            //if (clickedButtonNumber_index == SevenSegmentAmount)
            //{
            //    checkAnswer();
            //}
            
        }
        else if(answerCorrect == false && clickedButtonNumber_index == SevenSegmentAmount)
        {
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                SegmentRefresh();
                clickedButtonNumber_index = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Return)){ checkAnswer(); }
    }
    
    void ClickButton(MyButton NbButton, int n)
    {
        clickedButtonNumber[clickedButtonNumber_index] = n;
        NbButton.ChangeButtonColor();
        
        /*
        NbButton.GetComponent<MeshRenderer>().material.color = Color.gray; //按鍵按下後，改變一下顏色
        //Thread.Sleep(1);
        NbButton.GetComponent<MeshRenderer>().material.color = Color.white;
        */
        seven[clickedButtonNumber_index].SetSegment(n);
        clickedButtonNumber_index += 1;
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
        for(int i = 0;i < seven.Length; i++)
        {
            seven[i].SetSegment(-1);
        }
    }

    private void checkAnswer()
    {
        answerCorrect = true;
        //按數字鍵1時，變更material顏色
        //紀錄按過的數字
        for (int i = 0; i < SevenSegmentAmount; i++)
        {
            if (answerNumber[i] != clickedButtonNumber[i])
            {
                answerCorrect = false;
                break;
            }
        }

        if(answerCorrect == true)
        {

            for (int i = 0; i < ButtonAmount; i++)
            {
                NumberButton[i].ChangeButtonColor_yellow();
            }
            EnterButton.ChangeButtonColor_yellow();
            ClearButton.ChangeButtonColor_yellow();
            /*
            NumberButton_1.GetComponent<MeshRenderer>().material.color = Color.yellow;
            NumberButton_2.GetComponent<MeshRenderer>().material.color = Color.yellow;
            NumberButton_3.GetComponent<MeshRenderer>().material.color = Color.yellow;
            */
        }
        else
        {
            SegmentRefresh();
        }
        clickedButtonNumber_index = 0;
    }
}
