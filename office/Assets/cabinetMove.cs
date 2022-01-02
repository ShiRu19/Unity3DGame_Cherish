using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinetMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log("P z = " + transform.position.z + "\nLP z = " + transform.localPosition.z);
        //Vector3 pos = new Vector3(-2.86f, -0.16f, 1.16f);
        //this.transform.localPosition = ;
    }
    
    public int i = 0;
    public float z, zMin, zMax;
    //public GameObject cabinet;

    public Transform InPos, OutPos;
    private Transform old;
    // Update is called once per frame
    void Update()
    {
        Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        //Debug.Log(i + "z " + transform.position.z +"\n");
        //float zPos = transform.position.z;
        //Vector3 newPos = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(z, zMin, zMax));
        //transform.position = newPos;
        /*cabinet.GetComponent<Rigidbody>().position = new Vector3(
                                                            Mathf.Clamp(cabinet.GetComponent<Rigidbody>().position.z, zMin, zMax),
                                                            0.0f,
                                                            0.0f);*/
        //transform.position = Vector3.Lerp(InPos.position, OutPos.position, 1);
        /*if(transform.position.z != old.position.z)
        {
            Debug.Log("/nz = " + transform.position.z + "\nOutPos = " + OutPos.transform.position.z);
            old = this.transform;
        }

        Vector3 MaxPos = new Vector3(transform.position.x, transform.position.y, OutPos.transform.position.z);
        if (transform.position.z >= OutPos.transform.position.z)
        {
            transform.position = MaxPos;
        }*/
    }







    //public Vector3 p;
    /*private float CalculateLocation01(Transform hand)
    {
        Vector3 OriginVec3 = OutPos.position - InPos.position;

        float length = OriginVec3.magnitude;
        OriginVec3.Normalize();

        Vector3 InPos2Hand = hand.position - InPos.position;

        return Vector3.Dot(InPos2Hand, OriginVec3) / length;
    }

    protected virtual void HandAttachedUpdate()
    {
        float currentLocation = CalculateLocation01(transform);
        transform.position = Vector3.Lerp(InPos.position, OutPos.position, currentLocation);
    }

    private IEnumerator pullObject(Rigidbody collidedRigidbody)
    {
        while (Vector3.Distance(transform.parent.position, collidedRigidbody.transform.position) > 1.5f)
        {
            pullTimer -= Time.deltaTime;

            if (pullTimer < 0)
            {
                yield return new WaitForSeconds(0.333f);
                pullTimer = resetPullTimer;
            }
            else
            {
                collidedRigidbody.MovePosition(collidedRigidbody.transform.position + Vector3.up * pullSpeed * Time.deltaTime);
                yield return null;
            }
        }
    }*/
}
