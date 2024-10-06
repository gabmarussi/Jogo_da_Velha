using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool turnX = true;
    public bool turn0 = false;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text messageText;



    public void ClickButton1()
    {
        if (turnX)
        {
            text1.text = "X";
            turnX = false;
            turn0 = true;
        }
        while(turn0) 
        { 
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (4,5,6)
            if(text4.text == "0" && text5.text == "0"&& text6.text == "") 
            {
                text6.text = "0";
                turn0 = false;
                turnX=true;
                return;
            }
            if(text4.text=="0" && text6.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if(text5.text=="0" && text6.text== "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "") 
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text== "0"&&text5.text== "0"&&text8.text== "") 
            {
                text8.text="0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (3,6,9)
            if (text3.text == "0" && text6.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text9.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "0" && text9.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text7.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if(text5.text== "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO
            
            else
            {
                float random2 = Random.Range(0, 6);
                if (random2==0)
                {
                    if(text2.text== "") 
                    { 
                       text2.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }
                    
                }
                if (random2 == 1)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }
           
        }
        VictoryCheck();

    }//FUNCIONANDO
    public void ClickButton2()
    {
        if (turnX)
        {
            text2.text = "X";
            turnX = false;
            turn0 = true;
        }
        while (turn0)
        {
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "0" && text5.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "0" && text6.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text6.text == "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (1,4,7)
            if (text1.text == "0" && text4.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text7.text == "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "0" && text7.text == "0" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (3,6,9)
            if (text3.text == "0" && text6.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text9.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "0" && text9.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "0" && text5.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text9.text == "0" && text1.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text3.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
           
            ///VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text7.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text4.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text9.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if (text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO

            else
            {
                float random2 = Random.Range(0, 6);
                if (random2 == 0)
                {
                    if (text1.text == "")
                    {
                        text1.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 1)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }

        }
        VictoryCheck();
       
    }//FUNCIONANDO

    public void ClickButton3()
    {
        if (turnX)
        {
            text3.text = "X";
            turnX = false;
            turn0 = true;
        }
        while (turn0)
        {
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "0" && text5.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "0" && text6.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text6.text == "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (1,4,7)
            if (text1.text == "0" && text4.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text7.text == "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "0" && text7.text == "0" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text == "0" && text5.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "0" && text5.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text9.text == "0" && text1.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
           
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text3.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            ///VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text7.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text4.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text9.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
           
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if (text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO

            else
            {
                float random2 = Random.Range(0, 6);
                if (random2 == 0)
                {
                    if (text1.text == "")
                    {
                        text1.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 1)
                {
                    if (text2.text == "")
                    {
                        text2.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }

        }
        VictoryCheck();
    }//FUNCIONANDO
    public void ClickButton4()
    {
        if (turnX)
        {
            text4.text = "X";
            turnX = false;
            turn0 = true;
        }
        while (turn0)
        {
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "0" && text2.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text3.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text3.text == "0" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text == "0" && text5.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (3,6,9)
            if (text3.text == "0" && text6.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text9.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "0" && text9.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "0" && text5.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text9.text == "0" && text1.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text3.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            if (text7.text == "X" && text4.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text9.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if (text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO

            else
            {
                float random2 = Random.Range(0, 6);
                if (random2 == 0)
                {
                    if (text1.text == "")
                    {
                        text1.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 1)
                {
                    if (text2.text == "")
                    {
                        text2.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }

        }
        VictoryCheck();
    }//FUNCIONANDO
    public void ClickButton5()
    {
        if (turnX)
        {
            text5.text = "X";
            turnX = false;
            turn0 = true;
        }
        if (turn0)
        {
            if (text5.text == "")
            {
                text5.text = "0";
                turnX = true;
                turn0 = false;
            }
            else
            {
                float aleatorio = Random.Range(1, 8);
                if (aleatorio == 1)
                {
                    if (text1.text == "")
                    {
                        text1.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 2)
                {
                    if (text2.text == "")
                    {
                        text2.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 3)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 4)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 5)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 6)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 7)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
                if (aleatorio == 8)
                {
                    if (text9.text == "")
                    {
                        text9.text = "0";
                        turnX = true;
                        turn0 = false;
                    }
                }
            }
        }
    }//FAZER POR �LTIMO
    public void ClickButton6()
    {
        if (turnX)
        {
            text6.text = "X";
            turnX = false;
            turn0 = true;
        }
        while (turn0)
        {
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "0" && text2.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text3.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text3.text == "0" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (1,4,7)
            if (text1.text == "0" && text4.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text7.text == "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "0" && text7.text == "0" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text == "0" && text5.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "0" && text5.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text9.text == "0" && text1.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text3.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            if (text7.text == "X" && text4.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text1.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }

            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text9.text == "X" && text1.text == "")
            {
                text1.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if (text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO

            else
            {
                float random2 = Random.Range(0, 6);
                if (random2 == 0)
                {
                    if (text1.text == "")
                    {
                        text1.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 1)
                {
                    if (text2.text == "")
                    {
                        text2.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }

        }
        VictoryCheck();
    }//FUNCIONANDO
    public void ClickButton7()
    {
        if (turnX)
        {
            text7.text = "X";
            turnX = false;
            turn0 = true;
        }
        while(turn0) 
        { 
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (4,5,6)
            if(text4.text == "0" && text5.text == "0"&& text6.text == "") 
            {
                text6.text = "0";
                turn0 = false;
                turnX=true;
                return;
            }
            if(text4.text=="0" && text6.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if(text5.text=="0" && text6.text== "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "") 
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text== "0"&&text5.text== "0"&&text8.text== "") 
            {
                text8.text="0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (3,6,9)
            if (text3.text == "0" && text6.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text9.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "0" && text9.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text7.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if(text5.text== "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO
            
            else
            {
                float random2 = Random.Range(0, 6);
                if (random2==0)
                {
                    if(text1.text== "") 
                    { 
                       text1.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }
                    
                }
                if (random2 == 1)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text9.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }
           
        }
        VictoryCheck();

    }//FUNCIONANDO
    public void ClickButton8()
    {
        if (turnX)
        {
            text8.text = "X";
            turnX = false;
            turn0 = true;
        }
        while(turn0) 
        { 
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (4,5,6)
            if(text4.text == "0" && text5.text == "0"&& text6.text == "") 
            {
                text6.text = "0";
                turn0 = false;
                turnX=true;
                return;
            }
            if(text4.text=="0" && text6.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if(text5.text=="0" && text6.text== "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "") 
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text== "0"&&text5.text== "0"&&text8.text== "") 
            {
                text8.text="0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (3,6,9)
            if (text3.text == "0" && text6.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text9.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "0" && text9.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text7.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if(text5.text== "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO
            
            else
            {
                float random2 = Random.Range(0, 6);
                if (random2==0)
                {
                    if(text2.text== "") 
                    { 
                       text2.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }
                    
                }
                if (random2 == 1)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text9.text == "")
                    {
                        text9.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }
           
        }
        VictoryCheck();

    }//FUNCIONANDO
    public void ClickButton9()
    {
        if (turnX)
        {
            text9.text = "X";
            turnX = false;
            turn0 = true;
        }
        while(turn0) 
        { 
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (4,5,6)
            if(text4.text == "0" && text5.text == "0"&& text6.text == "") 
            {
                text6.text = "0";
                turn0 = false;
                turnX=true;
                return;
            }
            if(text4.text=="0" && text6.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if(text5.text=="0" && text6.text== "0" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "0" && text8.text == "0" && text9.text == "") 
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "0" && text9.text == "0" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "0" && text9.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (2,5,8)
            if (text2.text== "0"&&text5.text== "0"&&text8.text== "") 
            {
                text8.text="0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "0" && text8.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text8.text == "0" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA VERTICAL (3,6,9)
            if (text3.text == "0" && text6.text == "0" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text9.text == "0" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "0" && text9.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE GANHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "0" && text5.text == "0" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "0" && text7.text == "0" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "0" && text7.text == "0" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (1,2,3)
            if (text1.text == "X" && text2.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text3.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (4,5,6)
            if (text4.text == "X" && text5.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text4.text == "X" && text6.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text6.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA HORIZONTAL (7,8,9)
            if (text7.text == "X" && text8.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text7.text == "X" && text9.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text8.text == "X" && text9.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(1,4,7)
            if (text1.text == "X" && text4.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text7.text == "X" && text4.text == "")
            {
                text4.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(2,5,8)
            if (text2.text == "X" && text5.text == "X" && text8.text == "")
            {
                text8.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text2.text == "X" && text8.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text8.text == "X" && text2.text == "")
            {
                text2.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA VERTICAL(3,6,9)
            if (text3.text == "X" && text6.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text9.text == "X" && text6.text == "")
            {
                text6.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text6.text == "X" && text9.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(1,5,9)
            if (text1.text == "X" && text5.text == "X" && text9.text == "")
            {
                text9.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text1.text == "X" && text9.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE CONSEGUE ATRAPALHAR PELA DIAGONAL(3,5,7)
            if (text3.text == "X" && text5.text == "X" && text7.text == "")
            {
                text7.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text3.text == "X" && text7.text == "X" && text5.text == "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            if (text5.text == "X" && text7.text == "X" && text3.text == "")
            {
                text3.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //VERIFICA SE O MEIO EST� LIVRE (5)
            else if(text5.text== "")
            {
                text5.text = "0";
                turn0 = false;
                turnX = true;
                return;
            }
            //SEN�O, ALEATORIO NO RESTO
            
            else
            {
                float random2 = Random.Range(0, 6);
                if (random2==0)
                {
                    if(text2.text== "") 
                    { 
                       text2.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }
                    
                }
                if (random2 == 1)
                {
                    if (text3.text == "")
                    {
                        text3.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 2)
                {
                    if (text4.text == "")
                    {
                        text4.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 3)
                {
                    if (text6.text == "")
                    {
                        text6.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 4)
                {
                    if (text7.text == "")
                    {
                        text7.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }
                if (random2 == 5)
                {
                    if (text8.text == "")
                    {
                        text8.text = "0";
                        turn0 = false;
                        turnX = true;
                        return;
                    }
                    else
                    {
                        random2 = Random.Range(0, 6);
                    }

                }

            }
           
        }
        VictoryCheck();

    }//FUNCIONANDO

    public void VictoryCheck()
    {
        if(text1.text == "X" && text2.text == "X" && text3.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text1.text == "0" && text2.text == "0" && text3.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text4.text == "X" && text5.text == "X" && text6.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text4.text == "0" && text5.text == "0" && text6.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text7.text == "X" && text8.text == "X" && text9.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text7.text == "0" && text8.text == "0" && text9.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text1.text == "X" && text5.text == "X" && text9.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text1.text == "0" && text5.text == "0" && text9.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text3.text == "X" && text5.text == "X" && text7.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text3.text == "0" && text5.text == "0" && text7.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text1.text == "X" && text4.text == "X" && text7.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text1.text == "0" && text4.text == "0" && text7.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text2.text == "X" && text5.text == "X" && text8.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text2.text == "0" && text5.text == "0" && text8.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
        if(text3.text == "X" && text6.text == "X" && text9.text == "X")
        {
            messageText.text = "Jogador X ganhou";
        }
        if(text3.text == "0" && text6.text == "0" && text9.text == "0")
        {
            messageText.text = "Jogador O ganhou";
        }
    }

  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
