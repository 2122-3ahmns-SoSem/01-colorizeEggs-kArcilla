using UnityEngine;
using UnityEngine.UI;

public class Lamp : MonoBehaviour
{
    public bool lampOff = false;
    private bool lampStateSwitched = false;

    public Color myColor;
    
    void Start()
    {
        if (!lampOff)
        {
            GetComponent<Image>().color = Color.white;
        }
    }

    public bool isOff()
    {
        return lampOff;
    }

    void Update()
    {
        if (lampStateSwitched)
        {
            lampStateSwitched = false;

            GetComponent<Image>().color = lampOff ? myColor : Color.white; 
        }
    }

    public void SwitchOnOffState()
    {
        lampOff = !lampOff;
        lampStateSwitched = true;
    }

    public void SwitchOff(bool onOff)
    {
        lampOff = onOff;
        lampStateSwitched = true;
    }
}
