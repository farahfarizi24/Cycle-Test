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
            ChangeLanguageToEnglish();
        }
    }


    public void ChangeLanguageToEnglish()
    {
        //change the text to german
        Scene currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "Tutorial":
                InstructionText.text = "You will now watch a video of a bike rider. We will ask you to remember which way the bike went and what you saw along the way."
                ;
                StartInstructionText.text = "Press the green START button when you are ready to start.";
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                ButtonFinish.SetActive(false);
                MakeUnnecessaryNull();
                break;

            case "Landmark Test Tutorial":

                InstructionText.text = "You will now see some pictures. Click only on the things that you remember seeing along the way during the ride. ";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();

                break;
            case "Landmark Test":

                InstructionText.text = "What did you see along the way during the ride? Press the green START button when you are ready to start.";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();
                break;
            case "Route Mapping Tutorial":


                InstructionText.text = "Great! You will now see the video again. When the video stops choose which way the bike went by clicking the correct arrow as quickly as possible.";
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
    public void ChangeLanguageToGerman() 
    
    
    {//change the text to german
        Scene currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "Tutorial":
                InstructionText.text = "Du siehst nun ein Video von einem Fahrradfahrer, der durch die Stadt fährt. Bitte versuche dich daran zu erinnern, in welche Richtung das Fahrrad gefahren ist und was du auf dem Weg gesehen hast."
                ;
                StartInstructionText.text = "Drücke die grüne START-Taste, wenn du startbereit bist";
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                ButtonFinish.SetActive(false);  
                MakeUnnecessaryNull();
                break;

            case "Landmark Test Tutorial":

                InstructionText.text = "Du siehst nun einige Bilder. Klicke nur auf die Dinge, an die du dich erinnerst während der Fahrt gesehen zu haben. Drücke die grüne START-Taste, wenn du startbereit bist.";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();

                break;
            case "Landmark Test":

                InstructionText.text = "Was hast du während der Fahrt gesehen? Klicke in das Kästchen, um ein Bild auszuwählen. Klicke auf NEXT, um die nächsten Bilder anzuzeigen.";
                StartInstructionText = null;
                Debug.Log("Triggered");
                GermanAudioSource.clip = GermanClip;
                Debug.Log("GermanIsSelected");
                GermanAudioSource.Play();
                MakeUnnecessaryNull();
                break;
            case "Route Mapping Tutorial":


                InstructionText.text = "Großartig! Du siehst nun wieder das Video. Wenn das Video stoppt, wähle aus, in welche Richtung das Fahrrad gefahren ist, indem du so schnell wie möglich auf den richtigen Pfeil klickst. Drücke die grüne START-Taste, wenn du startbereit bist.";
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
