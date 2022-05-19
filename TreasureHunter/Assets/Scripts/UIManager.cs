using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] PlayerController playerController;
    public Text keyText;
    public Text swordText;
    public Text doorText;
    private int state;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        keyText.text = playerController.keys.ToString();
        swordText.text = playerController.swords.ToString();
        if(state == 1)
        {
            doorText.text = "No tienes llaves";
        }
        if(state == 2)
        {
            doorText.text = " ";
            state = 0;
        }
        
    }
    public void ShowMessage()
    {
        state = 1;
    }
    public void ApagarMensaje()
    {
        state = 2;    
    }
}
