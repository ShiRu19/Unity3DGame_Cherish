using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SevenSegment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetSegment(int num) 
    {
        int[] segmentEncoding = SevenSegmentDisplayCodeConversion(num);
        for(int i = 0; i < this.transform.childCount; i++)
        {
            if (segmentEncoding[i] == 0)
                this.gameObject.transform.GetChild(i).GetComponent<MeshRenderer>().material.color = Color.red;
            else if (segmentEncoding[i] == 1)
                this.gameObject.transform.GetChild(i).GetComponent<MeshRenderer>().material.color = Color.gray;
        }
    }

    private static int[] SevenSegmentDisplayCodeConversion(int n)
    {
        int[] SegmentEncoding = new int[] { 0, 0, 0, 0, 0, 0, 0 }; // SegmentEncoding of n
        int[,] Segment = new int[7, 10] { { 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 }, // Segment_a
                                            {0, 0, 0, 0, 0, 1, 1, 0, 0, 0 }, // Segment_b
                                            {0, 0, 1, 0, 0, 0, 0, 0, 0, 0 }, // Segment_c
                                            {0, 1, 0, 0, 1, 0, 0, 1, 0, 0 }, // Segment_d
                                            {0, 1, 0, 1, 1, 1, 0, 1, 0, 1 }, // Segment_e
                                            {0, 1, 1, 1, 0, 0, 0, 1, 0, 0 }, // Segment_f
                                            {1, 1, 0, 0, 0, 0, 0, 1, 0, 0 }}; // Segment_g

        if(n == -1) //refresh
        {
            for (int i = 0; i < 7; i++)
            {
                SegmentEncoding[i] = 1;
            }
        }
        else
        {
            for (int i = 0; i < 7; i++)
            {
                SegmentEncoding[i] = Segment[i, n];
            }
        }

        return SegmentEncoding;
    }
}
