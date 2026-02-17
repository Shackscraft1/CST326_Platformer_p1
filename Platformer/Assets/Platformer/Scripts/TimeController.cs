using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    
    public TextMeshProUGUI timeText;
    
    float timeLeft = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = $"Time\n  {(timeLeft).ToString("F0")}" ;
    }
}
