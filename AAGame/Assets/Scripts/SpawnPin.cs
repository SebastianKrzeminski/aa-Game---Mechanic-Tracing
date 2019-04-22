using UnityEngine;

public class SpawnPin : MonoBehaviour
{
    public GameObject pin;
    public Pin checkPin;

    private void Update()
    {
        if (checkPin.isPinned)
        {
            checkPin = Instantiate(pin, transform.position, transform.rotation).GetComponent<Pin>();
        }       
    }      
}
