using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UI, Level1, Level2, Level3, Level4, TitleScreen, Ending1;
    public int time, stamina;
    public TextMeshProUGUI timeText, staminaText;
    //Start is called before the first frame update.
    void Start()
    {
        TitleScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Changing the UI text value to our time int value
        timeText.text = time.ToString();
        staminaText.text = stamina.ToString();
    }

    public void StartGameButton()
    {
        //Making the title screen disable when pressing start
        TitleScreen.SetActive(false);
        //To make the 1st level active
        Level1.SetActive(true);
        //To make the UI active
        UI.SetActive(true);
        //Sets the value of the time to 10
        time = 10;
        //Sets the value of the stamina to 10
        stamina = 10;
    }

    public class Exit_Script : MonoBehaviour
    {
        public void QuitGameButton()
        {
            Application.Quit();
        }
    }

    //A method for one of our buttons.
    public void button_1()
    {
        //Making the level1 scene disable
        Level1.SetActive(false);
        //Making the level2 scene enable
        Level2.SetActive(true);
        //Reduces the value of the time by 5
        time -= 5;
        //Reduces the value of the Stamina by 3
        stamina -= 3;
    }

    //For button 2
    public void button_2()
    {
        //Making the level1 scene disable
        Level1.SetActive(false);
        //Making the level4 scene enable
        Level4.SetActive(true);
        //Reduces the value of the time by 2
        time -= 2;
        //Reduces the value of the Stamina by 7
        stamina -= 7;
    }

    //For button 3
    public void button_3()
    {
        //Making the level2 scene disable
        Level2.SetActive(false);
        //Making the level3 scene enable
        Level3.SetActive(true);
        //Reduces the value of the time by 1
        time -= 1;
        //Reduces the value of the Stamina by 2
        stamina -= 2;
    }

    //For button 4
    public void button_4()
    {
        //Making the level2 scene disable
        Level2.SetActive(false);
        //Making the level4 scene enable
        Level4.SetActive(true);
        //Reduces the value of the time by 2
        time -= 2;
        //Reduces the value of the Stamina by 6
        stamina -= 6;
    }

    //For button 5
    public void button_5()
    {
        //Making the level3 scene disable
        Level3.SetActive(false);
        //Making the level4 scene enable
        Level4.SetActive(true);
        //Reduces the value of the time by 1
        time -= 1;
        //Reduces the value of the Stamina by 4
        stamina -= 4;
    }

    //For button 6
    public void button_6()
    {
        //Making the level3 scene disable
        Level3.SetActive(false);
        //Making the Ending1 scene enable
        Ending1.SetActive(true);
        //Reduces the value of the time by 4
        time -= 4;
        //Reduces the value of the Stamina by 1
        stamina -= 1;
    }

    //For button 7 to go back to title screen after finishing the game.
    public void button_7()
    {
        //Making the level4 scene disable
        Level4.SetActive(false);
        //Making the Ending1 scene disable
        Ending1.SetActive(false);
        //Making the level2 scene enable
        TitleScreen.SetActive(true);
        //To make the UI disable
        UI.SetActive(false);
    }

    //For button 8 to go back to the start of the game after failing.
    public void button_8()
    {
        //Making the Ending1 scene disable
        Ending1.SetActive(false);
        //Making the level1 scene enable
        Level1.SetActive(true);
        //Resets the time value to 10
        time = 10;
        //Resets the time value to 10
        stamina = 10;
    }
}
