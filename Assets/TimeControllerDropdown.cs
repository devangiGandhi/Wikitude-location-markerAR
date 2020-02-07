using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControllerDropdown : MonoBehaviour
{
    public TextMesh CS, BS1, BS2, BS3;                               //CS is the text for charging status and BS is the status for car battery status.

    // for setting them true and false depending on the selected/not selected time         
    //public GameObject ChargeStatus, BatteryStatus;

    // public InputField value1;
    public Dropdown dropdownMenu;
    public Text SelectedTime;
    List<string> timeValue = new List<string>() { "Plese select time", "8 am", "9 am", "10 am", "11 am", "12 pm", "13 pm", "14 pm", "15 pm", "16 pm", "17 pm", "18 pm", "19 pm"};

    public void OnIndexVlaueChanged(int IndexNum)
    {       
        if(IndexNum == 0)
        {
            SelectedTime.text = timeValue[IndexNum];          
            //ChargeStatus.SetActive(false);
            //BatteryStatus.SetActive(false);
        }
        else
        {
            SelectedTime.text = "Selected Time is:" + timeValue[IndexNum];
            Setvalues();
        }

    }    

    // Start is called before the first frame update
    void Start()
    {
        //ChargeStatus.SetActive(false);
        //BatteryStatus.SetActive(false);
        TimeCount();        
    }

    void TimeCount()
    {
        dropdownMenu.AddOptions(timeValue);
    }

    void Setvalues()
    {
        //ChargeStatus.SetActive(true);
        //BatteryStatus.SetActive(true);
        CS.text = Random.Range(1, 22).ToString() + "KW";
        BS1.text = Random.Range(1, 100).ToString() + "%";
        BS2.text = Random.Range(1, 100).ToString() + "%";
        BS3.text = Random.Range(1, 100).ToString() + "%";

        /*
        int ran1 = Random.Range(0, 22);
        Debug.Log("Random value 1 is:" + ran1);
        value1.text = ran1.ToString();
        */
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
