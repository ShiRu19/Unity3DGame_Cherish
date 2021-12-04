using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick_main_2 : MonoBehaviour
{
    public int buttonAmount = 2;
    public int sevenSegmentAmount = 2;
    public MyButton[] accumulateButtons = new MyButton[2];
    public MyButton enterButton;
    public MyButton clearButton;
    public SevenSegment[] seven = new SevenSegment[2];
    public int[] answerNumber = new int[2];
    private int[] clickedButtonNumber = new int[2];
    private bool answerCorrect = false;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sevenSegmentAmount; i++)
        {
            clickedButtonNumber[i] = 0;
            seven[i].SetSegment(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (answerCorrect == false)
        {
            if (Input.GetKeyDown(KeyCode.L)) { ClickButton(accumulateButtons[0], 0, ++clickedButtonNumber[0]); } // Input left, left + 1
            if (Input.GetKeyDown(KeyCode.R)) { ClickButton(accumulateButtons[1], 1, ++clickedButtonNumber[1]); } // Input right, right + 1
            if (Input.GetKeyDown(KeyCode.Delete)){ SegmentRefresh(); }
            clickedButtonNumber[0] = clickedButtonNumber[0] % 10;
            clickedButtonNumber[1] = clickedButtonNumber[1] % 10;
        }
        if (Input.GetKeyDown(KeyCode.Return)) { checkAnswer(); }
        
    }
    void ClickButton(MyButton NbButton,int index, int n)
    {
        NbButton.ChangeButtonColor();
        seven[index].SetSegment(n % 10);
    }

    private void checkAnswer()
    {
        answerCorrect = true;
        //���Ʀr��1�ɡA�ܧ�material�C��
        //�������L���Ʀr
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
                accumulateButtons[i].ChangeButtonColor_yellow();
            }
            enterButton.ChangeButtonColor_yellow();
            clearButton.ChangeButtonColor_yellow();
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
