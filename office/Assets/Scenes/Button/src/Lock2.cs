using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock2 : MonoBehaviour
{
    public int buttonAmount = 3;
    public int sevenSegmentAmount = 3;
    public MyButton2[] accumulateButtons = new MyButton2[3];
    public MyButton2 enterButton;
    public MyButton2 clearButton;
    public SevenSegment[] seven = new SevenSegment[3];
    public int[] answerNumber = new int[3];
    public GameObject door;
    private int[] clickedButtonNumber = new int[3];
    private bool answerCorrect = false;

    //public GameObject obstacle;
    public GameObject drawer_move;
    public GameObject drawer_noMove;
    // Start is called before the first frame update
    void Start()
    {
        drawer_move.SetActive(false);
        for (int i = 0; i < sevenSegmentAmount; i++)
        {
            clickedButtonNumber[i] = 0;
            seven[i].SetSegment(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (answerCorrect == false)
        //{
        //    if (Input.GetKeyDown(KeyCode.L)) { ClickButton(accumulateButtons[0], 0, ++clickedButtonNumber[0]); } // Input left, left + 1
        //    if (Input.GetKeyDown(KeyCode.R)) { ClickButton(accumulateButtons[1], 1, ++clickedButtonNumber[1]); } // Input right, right + 1
        //    if (Input.GetKeyDown(KeyCode.Delete)){ SegmentRefresh(); }
        //    clickedButtonNumber[0] = clickedButtonNumber[0] % 10;
        //    clickedButtonNumber[1] = clickedButtonNumber[1] % 10;
        //}
        //if (Input.GetKeyDown(KeyCode.Return)) { checkAnswer(); }

    }
    public void ClickButton(MyButton2 NbButton, int index)
    {
        if (answerCorrect == false)
        {
            NbButton.ChangeButtonColor();
            seven[index - 1].SetSegment(++clickedButtonNumber[index - 1] % 10);
            Debug.Log(clickedButtonNumber[0] + "," + clickedButtonNumber[1]);
        }
    }

    public void checkAnswer()
    {
        answerCorrect = true;
        //按數字鍵1時，變更material顏色
        //紀錄按過的數字
        for (int i = 0; i < sevenSegmentAmount; i++)
        {
            if (answerNumber[i] != (clickedButtonNumber[i] % 10))
            {
                answerCorrect = false;
                break;
            }
        }

        if (answerCorrect == true)
        {
            for (int i = 0; i < buttonAmount; i++)
            {
                accumulateButtons[i].ChangeButtonColor_yellow();
            }
            enterButton.ChangeButtonColor_yellow();
            clearButton.ChangeButtonColor_yellow();
            //obstacle.SetActive(false);
            drawer_move.SetActive(true);
            drawer_noMove.SetActive(false);
            door.SetActive(false);
        }
        else
        {
            SegmentRefresh();
        }
    }
    public void SegmentRefresh()
    {
        for (int i = 0; i < sevenSegmentAmount; i++)
        {
            clickedButtonNumber[i] = 0;
            seven[i].SetSegment(0);
        }
    }
}
