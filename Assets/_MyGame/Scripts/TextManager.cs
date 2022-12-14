using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField]
    private Text text;

    [SerializeField]
    private InputField input;

    public void LoadText()
    {
        text.text = input.text;
    } 
}
