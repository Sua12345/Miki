using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    private string tempString;

    public void ButtonClickMethod()
    {
        textbox.text = "I have changed";
    }
}
