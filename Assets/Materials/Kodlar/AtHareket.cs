using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtHareket : MonoBehaviour
{
    public int speed;
    public GameObject finishUI;
    public Text kazanan;
    Vector3 FinishLine = new Vector3(0, 5, 600);
    Vector3 at0 = new Vector3(0, 0, 0);
    Vector3 at1 = new Vector3(0, 0, 0);
    Vector3 at2 = new Vector3(0, 0, 0);
    Vector3 at3 = new Vector3(0, 0, 0);
     //public Transform at0, at1, at2, at3,finishLine;
    //public float fark1,fark2,fark3,fark4;

    public void Update()
    {

        if (transform.position.z < 675)
        {
            speed = Random.Range(20, 100);
            Input.GetMouseButtonDown(0);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else
        {
            Input.GetMouseButtonDown(0);
            transform.Translate(Vector3.forward * 0);
            finishUI.SetActive(true);
        }

            float angle = Vector3.Distance(at0, FinishLine);
            float angle1 = Vector3.Distance(at1, FinishLine);
            float angle2 = Vector3.Distance(at2, FinishLine);
            float angle3 = Vector3.Distance(at3, FinishLine);
            for (float i = 0.0f; i < 2.0f; i++)
            {
                if (angle == i)
                {
                    kazanan.text = "BOLD PILOT KAZANDI ";
                }
                if (angle1 == i)
                {
                    kazanan.text = "DUBLIN BEYİ KAZANDI ";
                }
                if (angle2 == i)
                {
                    kazanan.text = "ZÜĞÜRT AĞA KAZANDI ";
                }
                if (angle3 == i)
                {
                    kazanan.text = "FREUD FETHİ KAZANDI ";
                }

            }
            
        }
    }
    
