using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LanguageScript : MonoBehaviour
{
    public static bool isEnglish;

    public TextMeshProUGUI Language;
    // Start is called before the first frame update
    public void SetGermanLanguage()
    {
        isEnglish = false;
        Debug.Log("Is german!");
        Language.text = "Deutschland";
    }
    public void SetEnglishLanguage()
    {
        isEnglish = true;
        Debug.Log("Is english!");
        Language.text = "English";
    }

    public void Awake()
    {
        isEnglish = true;
    }
}
