using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money1 : MonoBehaviour
{
    public int money = 0;
    public Text txt;
    public int t1 = 0;
    public int t2 = 0;
    public int t3 = 0;
    public int t4 = 0;
    public int t5 = 0;
    public int t6 = 0;
    public int t7 = 0;


    public int b1 = 0;
    public int b2 = 0;
    public int b3 = 0;
    public int b4 = 0;
    public int b5 = 0;
    public int b6 = 0;



    public int k1 = 0;
    public int k2 = 0;
    public int k3 = 0;
    public int k4 = 0;
    public int k5 = 0;


    public int v1 = 0;
    public int v2 = 0;
    public int v3 = 0;
    public int v4 = 0;
    public int v5 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = money.ToString();
    }

    public void li1()
    { if (t1 == 2) t1 = 0;

        if (t1 == 1)
        {
            money -= 10000;
            t1++;
        }
        if (t1 == 0)
        {
            money += 10000;
            t1++;
        }
    }
    public void li2()
    {
       
        if (t2 == 2) t2 = 0;

        if (t2 == 1)
        {
            money -= 8999;
            t2++;
        }
        if (t2 == 0)
        {
            money += 8999;
            t2++;
        }

    }
    public void li3()
    {
      
        if (t3 == 2) t3 = 0;

        if (t3 == 1)
        {
            money -= 15000;
            t3++;
        }
        if (t3 == 0)
        {
            money += 15000;
            t3++;
        }

    }
    public void li4()
    {
       
        if (t4 == 2) t4 = 0;

        if (t4 == 1)
        {
            money -= 5000;
            t4++;
        }
        if (t4 == 0)
        {
            money += 5000;
            t4++;
        }

    }
    public void li5()
    {
        if (t5 == 2) t5 = 0;

        if (t5 == 1)
        {
            money -= 6050;
            t5++;
        }
        if (t5 == 0)
        {
            money += 6050;
            t5++;
        }

    }
    public void li6()
    {
       
        if (t6 == 2) t6 = 0;

        if (t6 == 1)
        {
            money -= 4999;
            t6++;
        }
        if (t6 == 0)
        {
            money += 4999;
            t6++;
        }
    }
    public void li7()
    {
      

        if (t7 == 2) t7 = 0;

        if (t7 == 1)
        {
            money -= 7100;
            t7++;
        }
        if (t7 == 0)
        {
            money += 7100;
            t7++;
        }
    }





    public void be1()
    {
        if (b1 == 2) b1 = 0;

        if (b1 == 1)
        {
            money -= 10000;
            b1++;
        }
        if (b1 == 0)
        {
            money += 10000;
            b1++;
        }
    }
    public void be2()
    {

        if (b2 == 2) b2 = 0;

        if (b2 == 1)
        {
            money -= 11000;
            b2++;
        }
        if (b2 == 0)
        {
            money += 11000;
            b2++;
        }

    }
    public void be3()
    {

        if (b3 == 2) b3 = 0;

        if (b3 == 1)
        {
            money -= 3000;
            b3++;
        }
        if (b3 == 0)
        {
            money += 3000;
            b3++;
        }

    }
    public void bei4()
    {

        if (b4 == 2) b4 = 0;

        if (b4 == 1)
        {
            money -= 4050;
            b4++;
        }
        if (b4 == 0)
        {
            money += 4050;
            b4++;
        }

    }
    public void be5()
    {
        if (b5 == 2) b5 = 0;

        if (b5 == 1)
        {
            money -= 6000;
            b5++;
        }
        if (b5 == 0)
        {
            money += 6000;
            b5++;
        }

    }
    public void be6()
    {

        if (b6 == 2) b6 = 0;

        if (b6 == 1)
        {
            money -= 7010;
            b6++;
        }
        if (b6 == 0)
        {
            money += 7010;
            b6++;
        }
    }



    public void ku1()
    {
        if (k1 == 2) k1 = 0;

        if (k1 == 1)
        {
            money -= 23000;
            k1++;
        }
        if (k1 == 0)
        {
            money += 23000;
            k1++;
        }
    }
    public void ku2()
    {

        if (k2 == 2) k2 = 0;

        if (k2 == 1)
        {
            money -= 8900;
            k2++;
        }
        if (k2 == 0)
        {
            money += 8900;
            k2++;
        }

    }
    public void ku3()
    {

        if (k3 == 2) k3 = 0;

        if (k3 == 1)
        {
            money -= 9000;
            k3++;
        }
        if (k3 == 0)
        {
            money += 9000;
            k3++;
        }

    }
    public void ku4()
    {

        if (k4 == 2) k4 = 0;

        if (k4 == 1)
        {
            money -= 2000;
            k4++;
        }
        if (k4 == 0)
        {
            money += 2000;
            k4++;
        }

    }
    public void ku5()
    {
        if (k5 == 2) k5 = 0;

        if (k5 == 1)
        {
            money -= 2000;
            k5++;
        }
        if (k5 == 0)
        {
            money += 2000;
            k5++;
        }

    }





    public void vu1()
    {
        if (v1 == 2) v1 = 0;

        if (v1 == 1)
        {
            money -= 30000;
            v1++;
        }
        if (v1 == 0)
        {
            money += 30000;
            v1++;
        }
    }
    public void vu2()
    {

        if (v2 == 2) v2 = 0;

        if (v2 == 1)
        {
            money -= 15000;
            v2++;
        }
        if (v2 == 0)
        {
            money += 15000;
            v2++;
        }

    }
    public void vu3()
    {

        if (v3 == 2) v3 = 0;

        if (v3 == 1)
        {
            money -= 16000;
            v3++;
        }
        if (v3 == 0)
        {
            money += 16000;
            v3++;
        }

    }
    public void vu4()
    {

        if (v4 == 2) v4 = 0;

        if (v4 == 1)
        {
            money -= 10000;
            v4++;
        }
        if (v4 == 0)
        {
            money += 10000;
            v4++;
        }

    }
    public void vu5()
    {
        if (v5 == 2) v5 = 0;

        if (v5 == 1)
        {
            money -= 1000;
            v5++;
        }
        if (v5 == 0)
        {
            money += 1000;
            v5++;
        }

    }

}
