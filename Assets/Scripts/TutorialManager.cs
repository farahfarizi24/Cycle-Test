using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class TutorialManager : MonoBehaviour
{
  
    public TextMeshProUGUI InstructionText;
    public TextMeshProUGUI StartInstructionText;
    public AudioSource GermanAudioSource;
    public AudioClip GermanClip;

    public AudioSource DirectionGermanAudioSource;
    public AudioClip DirectionGermanClip;
    public AudioSource WrongAnswerGermanAudioSource;
    public AudioClip WrongAnswerGermanClip;
    public AudioSource CorrectAnswerGermanAudioSource;
    public AudioClip CorrectAnswerGermanClip;
    public GameObject ButtonFinish=null;
    // Start is called before the first frame update
    void Start()
    {


        if (LanguageScript.isEnglish.Equals(false)) {

          ChangeLanguageToGerman();
        }
        else
        {
            Debug.Log("IsEn");
        }
    }


    public void ChangeLanguageToGerman() 
    
    
    {//change the text to german
        Scene currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "Tutorial":
                InstructionText.text = "Du siehst nun ein Video von einem Fahrradfahrer, der durch die Stadt f�hrt. Bitte versuche dich daran zu erinnern, in welche Richtung das Fahrrad gefahren ist und was du auf dem Weg gesehen hast."
                ;
                StartInstructionText.text = "Dr�cke die gr�ne START-Taste, wenn du startbereit bist";
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                ButtonFinish.SetActive(false);  
                MakeUnnecessaryNull();
                break;

            case "Landmark Test Tutorial":

                InstructionText.text = "Du siehst nun einige Bilder. Klicke nur auf die Dinge, an die du dich erinnerst w�hrend der Fahrt gesehen zu haben. Dr�cke die gr�ne START-Taste, wenn du startbereit bist.";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();

                break;
            case "Landmark Test":

                InstructionText.text = "Was hast du w�hrend der Fahrt gesehen? Klicke in das K�stchen, um ein Bild auszuw�hlen. Klicke auf NEXT, um die n�chsten Bilder anzuzeigen.";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();
                break;
            case "Route Mapping Tutorial":


                InstructionText.text = "Gro�artig! Du siehst nun wieder das Video. Wenn das Video stoppt, w�hle aus, in welche Richtung das Fahrrad gefahren ist, indem du so schnell wie m�glich auf den richtigen Pfeil klickst. Dr�cke die gr�ne START-Taste, wenn du startbereit bist.";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();
                break;


            case "Route Mapping Test":

                //Thanks method
                InstructionText.text = "Finish";
                StartInstructionText = null;
                Debug.Log("Triggered");
                //Thanks audio;
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                //GermanAudioSource.Play();
                DirectionGermanAudioSource.clip = DirectionGermanClip;
                WrongAnswerGermanAudioSource.clip = WrongAnswerGermanClip;
                CorrectAnswerGermanAudioSource.clip = CorrectAnswerGermanClip;



                break;


        }


    }

    public void MakeUnnecessaryNull()
    {
DirectionGermanAudioSource= null;
 DirectionGermanClip= null;
 WrongAnswerGermanAudioSource= null;
  WrongAnswerGermanClip= null;
 CorrectAnswerGermanAudioSource = null;
 CorrectAnswerGermanClip = null;
}
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
