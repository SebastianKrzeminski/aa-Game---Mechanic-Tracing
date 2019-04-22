using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text scoreText;

    private void Start()
    {
        PinCount = 0;
    }

    private void Update()
    {
        scoreText.text = PinCount.ToString(); 
    }
}
