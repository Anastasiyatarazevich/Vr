using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instant : MonoBehaviour
{
    public int Money=0;
    public Text txt;


    public Button but1;public int tch = 0;
    public int beds1 =0;
    public int bedsde1 = 0;
    public GameObject bed1; public int mn2 = 0;
    public GameObject bedde1;
    public GameObject bed2; public int tch2 = 0;
    public GameObject cupboard1; public int tch3 = 0;
    public GameObject cupboard2; public int tch4 = 0;
    public GameObject schoolarm1; public int tch5 = 0;
    public GameObject table1; public int tch6 = 0;
    public GameObject table2;
    public GameObject bath; public int tch7 = 0;
    public GameObject toilet; public int tch8 = 0;
    public GameObject toilet1; public int tch9 = 0;
    public GameObject sink; public int tch10 = 0;
    public GameObject dryer; public int tch11 = 0;
    public GameObject sofa1; public int tch12 = 0;
    public GameObject sofa2; public int tch13 = 0;
    public GameObject tv; public int tch14 = 0;
    public GameObject lt1; public int tch67 = 0;

   // public GameObject laptop;
    public GameObject armchair1; public int tch15 = 0;
    public GameObject armchair2; public int tch16 = 0;
    public GameObject fridge; public int tch17 = 0;
    public GameObject table3; public int tch18 = 0;
    public GameObject table4; public int tch19 = 0;
    public GameObject chair1; public int tch20 = 0;
    public GameObject chair2; public int tch21 = 0;


    public GameObject bed21; public int tch22 = 0;
    public GameObject bed22; public int tch23 = 0;
    public GameObject cupboard21; public int tch24 = 0;
    public GameObject cupboard22; public int tch25 = 0;
    public GameObject schoolarm2; public int tch26 = 0;
    public GameObject table21; public int tch27 = 0;
    public GameObject table22; public int tch28 = 0;
    public GameObject bath2; public int tch29 = 0;
    public GameObject toilet2; public int tch31 = 0;
    public GameObject toilet21; public int tch32 = 0;
    public GameObject sink2; public int tch30 = 0;
    public GameObject dryer2; public int tch33 = 0;
    public GameObject sofa21; public int tch34 = 0;
    public GameObject sofa22; public int tch35 = 0;
    public GameObject tv2; public int tch36 = 0;
   // public GameObject laptop2;
    public GameObject armchair21; public int tch37 = 0;
    public GameObject armchair22; public int tch38 = 0;
    public GameObject fridge2; public int tch39 = 0;
    public GameObject table23; public int tch40 = 0;
    public GameObject table24; public int tch41 = 0;
    public GameObject chair21; public int tch42 = 0;
    public GameObject chair22; public int tch43 = 0;
    public GameObject lt2; public int tch68 = 0;

    public GameObject bed31; public int tch44 = 0;
    public GameObject bed32; public int tch45 = 0;
    public GameObject cupboard31; public int tch46 = 0;
    public GameObject cupboard32; public int tch47 = 0;
    public GameObject table31; public int tch48 = 0;
    public GameObject table32; public int tch49 = 0;
    public GameObject bath3; public int tch50 = 0;
    public GameObject toilet3; public int tch51 = 0;
    public GameObject toilet31; public int tch52 = 0;
    public GameObject sink3; public int tch53 = 0;
    public GameObject dryer3; public int tch54 = 0;
    public GameObject sofa31; public int tch55 = 0;
    public GameObject sofa3; public int tch56 = 0;
    public GameObject tv3; public int tch57 = 0;
   // public GameObject laptop3; public int tch58 = 0;
    public GameObject armchair31; public int tch59 = 0;
    public GameObject armchair32; public int tch60 = 0;
    public GameObject fridge3; public int tch61 = 0;
    public GameObject table33; public int tch62 = 0;
    public GameObject table34; public int tch63 = 0;
    public GameObject chair31; public int tch64 = 0;
    public GameObject chair32; public int tch65 = 0;
    public GameObject schoolarm3; public int tch66 = 0;
    public GameObject lt3; public int tch69 = 0;


    public GameObject tum1; public int tch70 = 0; public int mn1 = 0;
    public GameObject tum2; public int tch71 = 0;
    public GameObject tum3; public int tch72 = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /* public void But11()
     {
         // Instantiate(bed1); 

        if(beds1==3)
             but1.interactable = false;
         else
             but1.interactable = true;

     }*/
    public void Tum3()
    {
        if (tch72 == 2) tch72 = 0;
        if (tch72 == 1)
        {
           
            tum3.SetActive(false); tch72++;

        }
        if (tch72 == 0)
        {
            tum3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch72++;
        }
    }
    public void Tum2()
    {
        if (tch71 == 2) tch71 = 0;
        if (tch71 == 1)
        {
          
            tum2.SetActive(false); tch71++;

        }
        if (tch71 == 0)
        {
           
            tum2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch71++;
        }
    }
    public void Tum1()
    {
        if (tch70 == 2) tch70 = 0;
        if (tch70 == 1)
        {
            
            tum1.SetActive(false); tch70++;

        }
        if (tch70 == 0)
        {
            
            tum1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch70++;
        }
    }
        public void Bed1()
    {
        if (tch == 2) tch = 0;
            if (tch == 1) {
           
            bed1.SetActive(false); tch++;

    }
        if (tch == 0)
        {
           
            bed1.SetActive(true);
        //but1.GetComponent<Interact>().enabled = true;
        tch++;
    }
    }
    public void Bed2()
    {
        if (tch2 == 2) tch2 = 0;
        if (tch2 == 1)
        {
            bed2.SetActive(false); tch2++;

        }
        if (tch2 == 0)
        {
            bed2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch2++;
        }
    }
    public void Cupboard1()
    {
        if (tch3 == 2) tch3 = 0;
        if (tch3 == 1)
        {
           cupboard1.SetActive(false); tch3++;

        }
        if (tch3 == 0)
        {
           cupboard1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch3++;
        }
    }
    public void Cupboard2()
    {
        if (tch4 == 2) tch4 = 0;
        if (tch4 == 1)
        {
            cupboard2.SetActive(false); tch4++;

        }
        if (tch4 == 0)
        {
            cupboard2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch4++;
        }
    }
    public void Schoolarm1()
    {
        if (tch5 == 2) tch5 = 0;
        if (tch5 == 1)
        {
            schoolarm1.SetActive(false); tch5++;

        }
        if (tch5 == 0)
        {
            schoolarm1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch5++;
        }
    }
    public void Table1()
    {
        if (tch6 == 2) tch6 = 0;
        if (tch6 == 1)
        {
            table1.SetActive(false); tch6++;

        }
        if (tch6 == 0)
        {
            table1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch6++;
        }
    }
    public void Table2()
    {
        Instantiate(table2);
    }
    public void Bath()
    {
        if (tch7 == 2) tch7 = 0;
        if (tch7 == 1)
        {
            bath.SetActive(false); tch7++;

        }
        if (tch7 == 0)
        {
            bath.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch7++;
        }
    }
    public void Toilet()
    {
        if (tch8 == 2) tch8 = 0;
        if (tch8 == 1)
        {
            toilet.SetActive(false); tch8++;

        }
        if (tch8 == 0)
        {
            toilet.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch8++;
        }
    }
        public void Sink()
    {
        if (tch10 == 2) tch10 = 0;
        if (tch10 == 1)
        {
            sink.SetActive(false); tch10++;

        }
        if (tch10 == 0)
        {
            sink.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch10++;
        }
    }
    public void Toilet1()
    {
        if (tch9 == 2) tch9 = 0;
        if (tch9 == 1)
        {
            toilet1.SetActive(false); tch9++;

        }
        if (tch9 == 0)
        {
            toilet1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch9++;
        }
    }
    public void Dryer()
    {
        if (tch11 == 2) tch11 = 0;
        if (tch11 == 1)
        {
            dryer.SetActive(false); tch11++;

        }
        if (tch11 == 0)
        {
            dryer.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch11++;
        }
    }
    public void Sofa1()
    {
        if (tch12 == 2) tch12 = 0;
        if (tch12 == 1)
        {
            sofa1.SetActive(false); tch12++;

        }
        if (tch12 == 0)
        {
            sofa1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch12++;
        }
    }
    public void Sofa2()
    {
        if (tch13 == 2) tch13 = 0;
        if (tch13 == 1)
        {
            sofa2.SetActive(false); tch13++;

        }
        if (tch13 == 0)
        {
            sofa2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch13++;
        }
    }
    public void TV()
    {

        if (tch14 == 2) tch14 = 0;
        if (tch14 == 1)
        {
            tv.SetActive(false); tch14++;

        }
        if (tch14 == 0)
        {
            tv.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch14++;
        }



    }
    public void Laptop()
    {
        if (tch67 == 2) tch67 = 0;
        if (tch67 == 1)
        {
            lt1.SetActive(false); tch67++;

        }
        if (tch67 == 0)
        {
            lt1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch67++;
        }
    }
    public void Armchair1()
    {
        if (tch15 == 2) tch15 = 0;
        if (tch15 == 1)
        {
            armchair1.SetActive(false); tch15++;

        }
        if (tch15 == 0)
        {
            armchair1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch15++;
        }
    }
    public void Armchair2()
    {
        if (tch16 == 2) tch16 = 0;
        if (tch16 == 1)
        {
            armchair2.SetActive(false); tch16++;

        }
        if (tch16 == 0)
        {
            armchair2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch16++;
        }
    }
        public void Fridge()
    {
        if (tch17 == 2) tch17 = 0;
        if (tch17 == 1)
        {
            fridge.SetActive(false); tch17++;

        }
        if (tch17 == 0)
        {
            fridge.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch17++;
        }
    }
    public void Table3()
    {
        if (tch18 == 2) tch18 = 0;
        if (tch18 == 1)
        {
            table3.SetActive(false); tch18++;

        }
        if (tch18 == 0)
        {
            table3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch18++;
        }
    }
    public void Table4()
    {
        if (tch19 == 2) tch19 = 0;
        if (tch19 == 1)
        {
            table4.SetActive(false); tch19++;

        }
        if (tch19 == 0)
        {
            table4.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch19++;
        }
    }
    public void Chair1()
    {
        if (tch20 == 2) tch20 = 0;
        if (tch20 == 1)
        {
            chair1.SetActive(false); tch20++;

        }
        if (tch20 == 0)
        {
            chair1.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch20++;
        }
    }
        public void Chair2()
    {
        if (tch21 == 2) tch21 = 0;
        if (tch21 == 1)
        {
            chair2.SetActive(false); tch21++;

        }
        if (tch21 == 0)
        {
            chair2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch21++;
        }
    }



    public void Bed21()
    {
        if (tch22 == 2) tch22 = 0;
        if (tch22 == 1)
        {
            bed21.SetActive(false); tch22++;

        }
        if (tch22 == 0)
        {
           bed21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch22++;
        }
    }
    public void Bed22()
    {
        if (tch23 == 2) tch23 = 0;
        if (tch23 == 1)
        {
            bed22.SetActive(false); tch23++;

        }
        if (tch23 == 0)
        {
            bed22.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch23++;
        }
    }
    public void Cupboard21()
    {
        if (tch24 == 2) tch24 = 0;
        if (tch24 == 1)
        {
            cupboard21.SetActive(false); tch24++;

        }
        if (tch24 == 0)
        {
            cupboard21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch24++;
        }
    }
    public void Cupboard22()
    {
        if (tch25 == 2) tch25 = 0;
        if (tch25 == 1)
        {
            cupboard22.SetActive(false); tch25++;

        }
        if (tch25 == 0)
        {
            cupboard22.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch25++;
        }
    }
    public void Schoolarm2()
    {
        if (tch26 == 2) tch26 = 0;
        if (tch26 == 1)
        {
            schoolarm2.SetActive(false); tch26++;

        }
        if (tch26 == 0)
        {
            schoolarm2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch26++;
        }
    }
    public void Table21()
    {
        if (tch27 == 2) tch27 = 0;
        if (tch27 == 1)
        {
            table21.SetActive(false); tch27++;

        }
        if (tch27 == 0)
        {
            table21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch27++;
        }
    }
    public void Table22()
    {
        if (tch28 == 2) tch28 = 0;
        if (tch28 == 1)
        {
            table22.SetActive(false); tch28++;

        }
        if (tch28 == 0)
        {
            table22.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch28++;
        }
    }
    public void Bath2()
    {
        if (tch29 == 2) tch29 = 0;
        if (tch29 == 1)
        {
            bath2.SetActive(false); tch29++;

        }
        if (tch29 == 0)
        {
            bath2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch29++;
        }
    }
    public void Toilet2()
    {
        if (tch31 == 2) tch31 = 0;
        if (tch31 == 1)
        {
            toilet2.SetActive(false); tch31++;

        }
        if (tch31 == 0)
        {
           toilet2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch31++;
        }
    }
    public void Sink2()
    {
        if (tch30 == 2) tch30 = 0;
        if (tch30 == 1)
        {
            sink2.SetActive(false); tch30++;

        }
        if (tch30 == 0)
        {
            sink2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch30++;
        }
    }
    public void Toilet21()
    {
        if (tch32 == 2) tch32 = 0;
        if (tch32 == 1)
        {
            toilet21.SetActive(false); tch32++;

        }
        if (tch32 == 0)
        {
            toilet21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch32++;
        }
    }
    public void Drye2r()
    {
        if (tch33 == 2) tch33 = 0;
        if (tch33 == 1)
        {
            dryer2.SetActive(false); tch33++;

        }
        if (tch33 == 0)
        {
            dryer2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch33++;
        }
    }
    public void Sofa21()
    {
        if (tch34 == 2) tch34 = 0;
        if (tch34 == 1)
        {
            sofa21.SetActive(false); tch34++;

        }
        if (tch34 == 0)
        {
            sofa21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch34++;
        }
    }
    public void Sofa22()
    {
        if (tch35 == 2) tch35 = 0;
        if (tch35 == 1)
        {
            sofa22.SetActive(false); tch35++;

        }
        if (tch35 == 0)
        {
            sofa22.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch35++;
        }
    }
    public void TV2()
    {
        if (tch36 == 2) tch36 = 0;
        if (tch36 == 1)
        {
            tv2.SetActive(false); tch36++;

        }
        if (tch36 == 0)
        {
            tv2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch36++;
        }
    }
    public void Laptop2()
    {
        if (tch68 == 2) tch68 = 0;
        if (tch68 == 1)
        {
            lt2.SetActive(false); tch68++;

        }
        if (tch68 == 0)
        {
            lt2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch68++;
        }
    }
    public void Armchair21()
    {
        if (tch37 == 2) tch37 = 0;
        if (tch37 == 1)
        {
            armchair21.SetActive(false); tch37++;

        }
        if (tch37 == 0)
        {
            armchair21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch37++;
        }
    }
    public void Armchair22()
    {
        if (tch38 == 2) tch38 = 0;
        if (tch38 == 1)
        {
            armchair22.SetActive(false); tch38++;

        }
        if (tch38 == 0)
        {
            armchair22.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch38++;
        }
    }
    public void Fridge2()
    {
        if (tch39 == 2) tch39 = 0;
        if (tch39 == 1)
        {
            fridge2.SetActive(false); tch39++;

        }
        if (tch39 == 0)
        {
            fridge2.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch39++;
        }
    }
    public void Table23()
    {
        if (tch40 == 2) tch40 = 0;
        if (tch40 == 1)
        {
            table23.SetActive(false); tch40++;

        }
        if (tch40 == 0)
        {
            table23.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch40++;
        }
    }
    public void Table24()
    {
        if (tch41 == 2) tch41 = 0;
        if (tch41 == 1)
        {
            table24.SetActive(false); tch41++;

        }
        if (tch41 == 0)
        {
            table24.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch41++;
        }
    }
    public void Chair21()
    {
        if (tch42 == 2) tch42 = 0;
        if (tch42 == 1)
        {
            chair21.SetActive(false); tch42++;

        }
        if (tch42 == 0)
        {
            chair21.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch42++;
        }
    }
    public void Chair22()
    {
        if (tch43 == 2) tch43 = 0;
        if (tch43 == 1)
        {
            chair22.SetActive(false); tch43++;

        }
        if (tch43 == 0)
        {
            chair22.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch43++;
        }
    }








    public void Bed31()
    {
        if (tch44 == 2) tch44 = 0;
        if (tch44 == 1)
        {
            bed31.SetActive(false); tch44++;

        }
        if (tch44 == 0)
        {
            bed31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch44++;
        }
    }
    public void Bed32()
    {
        if (tch45 == 2) tch45 = 0;
        if (tch45 == 1)
        {
            bed32.SetActive(false); tch45++;

        }
        if (tch45 == 0)
        {
            bed32.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch45++;
        }
    }
    public void Cupboard31()
    {
        if (tch46 == 2) tch46 = 0;
        if (tch46 == 1)
        {
            cupboard31.SetActive(false); tch46++;

        }
        if (tch46 == 0)
        {
            cupboard31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch46++;
        }
    }
    public void Cupboard32()
    {
        if (tch47 == 2) tch47 = 0;
        if (tch47 == 1)
        {
            cupboard32.SetActive(false); tch47++;

        }
        if (tch47 == 0)
        {
            cupboard32.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch47++;
        }
    }
    public void Schoolarm3()
    {
        if (tch66 == 2) tch66 = 0;
        if (tch66 == 1)
        {
            schoolarm3.SetActive(false); tch66++;

        }
        if (tch66 == 0)
        {
            schoolarm3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch66++;
        }
    }
    public void Table31()
    {
        if (tch48 == 2) tch48 = 0;
        if (tch48 == 1)
        {
            table31.SetActive(false); tch48++;

        }
        if (tch48 == 0)
        {
            table31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch48++;
        }
    }
    public void Table32()
    {
        if (tch49 == 2) tch49 = 0;
        if (tch49 == 1)
        {
            table32.SetActive(false); tch49++;

        }
        if (tch49 == 0)
        {
            table32.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch49++;
        }
    }
    public void Bath3()
    {
        if (tch50 == 2) tch50 = 0;
        if (tch50 == 1)
        {
            bath3.SetActive(false); tch50++;

        }
        if (tch50 == 0)
        {
            bath3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch50++;
        }
    }
    public void Toilet3()
    {
        if (tch51 == 2) tch51 = 0;
        if (tch51 == 1)
        {
            toilet3.SetActive(false); tch51++;

        }
        if (tch51 == 0)
        {
            toilet3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch51++;
        }
    }
    public void Sink3()
    {
        if (tch53 == 2) tch53 = 0;
        if (tch53 == 1)
        {
            sink3.SetActive(false); tch53++;

        }
        if (tch53 == 0)
        {
            sink3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch53++;
        }
    }
    public void Toilet31()
    {
        if (tch52 == 2) tch52 = 0;
        if (tch52 == 1)
        {
            toilet31.SetActive(false); tch52++;

        }
        if (tch52 == 0)
        {
            toilet31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch52++;
        }
    }
    public void Drye3r()
    {
        if (tch54 == 2) tch54 = 0;
        if (tch54 == 1)
        {
            dryer3.SetActive(false); tch54++;

        }
        if (tch54 == 0)
        {
            dryer3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch54++;
        }
    }
    public void Sofa31()
    {
        if (tch55 == 2) tch55 = 0;
        if (tch55 == 1)
        {
            sofa31.SetActive(false); tch55++;

        }
        if (tch55 == 0)
        {
            sofa31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch55++;
        }
    }
    public void Sofa32()
    {
        if (tch56 == 2) tch56 = 0;
        if (tch56 == 1)
        {
            sofa3.SetActive(false); tch56++;

        }
        if (tch56 == 0)
        {
            sofa3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch56++;
        }
    }
    public void TV3()
    {
        if (tch57 == 2) tch57 = 0;
        if (tch57 == 1)
        {
            tv3.SetActive(false); tch57++;

        }
        if (tch57 == 0)
        {
            tv3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch57++;
        }
    }
    public void Laptop3()
    {
        if (tch69 == 2) tch69 = 0;
        if (tch69 == 1)
        {
            lt3.SetActive(false); tch69++;

        }
        if (tch69 == 0)
        {
            lt3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch69++;
        }
    }
    public void Armchair31()
    {
        if (tch59 == 2) tch59 = 0;
        if (tch59 == 1)
        {
            armchair31.SetActive(false); tch59++;

        }
        if (tch59 == 0)
        {
            armchair31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch59++;
        }
    }
    public void Armchair32()
    {
        if (tch60 == 2) tch60 = 0;
        if (tch60 == 1)
        {
            armchair32.SetActive(false); tch60++;

        }
        if (tch60 == 0)
        {
            armchair32.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch60++;
        }
    }
    public void Fridge3()
    {
        if (tch61 == 2) tch61 = 0;
        if (tch61 == 1)
        {
            fridge3.SetActive(false); tch61++;

        }
        if (tch61 == 0)
        {
            fridge3.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch61++;
        }
    }
    public void Table33()
    {
        if (tch62 == 2) tch62 = 0;
        if (tch62 == 1)
        {
            table33.SetActive(false); tch62++;

        }
        if (tch62 == 0)
        {
            table33.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch62++;
        }
    }
    public void Table34()
    {
        if (tch63 == 2) tch63 = 0;
        if (tch63 == 1)
        {
            table34.SetActive(false); tch63++;

        }
        if (tch63 == 0)
        {
            table34.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch63++;
        }
    }
    public void Chair31()
    {
        if (tch64 == 2) tch64 = 0;
        if (tch64 == 1)
        {
            chair31.SetActive(false); tch64++;

        }
        if (tch64 == 0)
        {
            chair31.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch64++;
        }
    }
    public void Chair32()
    {
        if (tch65 == 2) tch65 = 0;
        if (tch65 == 1)
        {
            chair32.SetActive(false); tch65++;

        }
        if (tch65 == 0)
        {
            chair32.SetActive(true);
            //but1.GetComponent<Interact>().enabled = true;
            tch65++;
        }
    }
}
