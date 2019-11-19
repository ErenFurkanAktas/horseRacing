using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Oran : MonoBehaviour
{

    public InputField oran1;
    public InputField oran2;
    public InputField oran3;
    public InputField oran4;
    public InputField bahis;
    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;
    public Text kazanc;
    public double a, b, c, d;
    public double z = 0;

    public void belirt()
    {
        a = Random.Range(1.10f,4.99f);
        b = Random.Range(1.10f, 4.99f);
        c = Random.Range(1.10f, 4.99f);
        d = Random.Range(1.10f, 4.99f);
        oran1.text = (a - a % 0.01).ToString();
        oran2.text = (b - b % 0.01).ToString();
        oran3.text = (c - c % 0.01).ToString();
        oran4.text = (d - d % 0.01).ToString();
    }
    public void goster()
    {
        z = 0;
       

        if (toggle1.GetComponent<Toggle>().isOn == true)
        {
            z += double.Parse(oran1.text) * double.Parse(bahis.text);

        }
        if (toggle2.GetComponent<Toggle>().isOn == true)
        {
            z += double.Parse(oran2.text) * double.Parse(bahis.text);

        }
        if (toggle3.GetComponent<Toggle>().isOn == true)
        {
            z += double.Parse(oran3.text) * double.Parse(bahis.text);

        }
        if (toggle4.GetComponent<Toggle>().isOn == true)
        {
            z += double.Parse(oran4.text) * double.Parse(bahis.text);

        }
        kazanc.text = "Tahmini kazancınız " + z.ToString();
    }

}
