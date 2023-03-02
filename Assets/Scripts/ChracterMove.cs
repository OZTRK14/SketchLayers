using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterMove : MonoBehaviour
{
    Vector3 screenPoint;
    Vector3 offset;
    Vector3 realPoint;
    Vector3 realPosition;


    public float MoveRange = 2f;
    public float Speed = 5f;
    public float Speed1 = 12f;    
    public float Say = 2;



    private void Update()
    {



        //Kamera ileri Hareket
        //*Camera.main.transform.Translate(transform.forward * Time.deltaTime * Speed1, Space.World);
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(Camera.main.transform.position.x, transform.position.y + 25, transform.position.z - 35), .5f);

        //?leri Hareket
        transform.Translate(transform.forward * Time.deltaTime * Speed, Space.World);

        //E?er range içindeyse yana harekete et


        if (transform.position.x > -MoveRange && transform.position.x < MoveRange)
        {
            AxisXMovement();
        }







    }

    void AxisXMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // T?klanmayla gerçek konum aras?ndaki fark hesaplan?p offsete ekleniyor

            screenPoint = Camera.main.WorldToScreenPoint(transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));


        }
        if (Input.GetMouseButton(0))
        {

            realPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            realPosition = Camera.main.ScreenToWorldPoint(realPoint) + offset;

            if (realPosition.x > -MoveRange && realPosition.x < MoveRange)
            {
                // X ekseninde hareket için positionda sadece x parametresi de?i?tirildi 
                transform.position = new Vector3(realPosition.x, transform.position.y, transform.position.z);

            }


        }





    }
}
