using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class VideoPlayback : MonoBehaviour
{
    public VideoPlayer player;
    public UnityEngine.UI.Button correct_arrow;
    public UnityEngine.UI.Button wrong_arrow;
    public UnityEngine.UI.Button wrong_arrow1;
    public UnityEngine.UI.Button wrong_arrow2;
    public Canvas canvas;
    public UnityEngine.UI.Image correct_alert;
    public UnityEngine.UI.Image wrong_alert;
    private Vector3 position_correct;
    private Vector3 rotation_correct;
    private Vector3 position_wrong;
    private Vector3 rotation_wrong;
    private Vector3 position_wrong1;
    private Vector3 rotation_wrong1;
    private int question_no = 0;
    public AudioSource correct_audio;
    public AudioSource wrong_audio;
    public AudioSource finish_audio;
    public AudioSource which_way;
    public int sceneID;
    public DataCollection data;
    //private UnityEngine.UI.Button newCorrect;
    //private UnityEngine.UI.Button newWrong;
    public bool instantiated;
    public GameObject[] gameobjects;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
      
        correct_arrow.onClick.AddListener(CorrectClick);
        wrong_arrow.onClick.AddListener(WrongClick);
        wrong_arrow1.onClick.AddListener(WrongClick);
        wrong_arrow2.onClick.AddListener(WrongClick);
        player.loopPointReached += Finish;
        instantiated = false;
        //correct_alert.transform.SetParent(null, false);
        //wrong_alert.transform.SetParent(null, false);
    }

    // Update is called once per frame
    void Update()
    {
        VideoTwo();


    }

    void Finish(UnityEngine.Video.VideoPlayer vp)
    {
        for (int i = 0; i < gameobjects.Length; i++)
        {
            gameobjects[i].transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform,false);
        }


        DataCollection.final_intersection =false;
        finish_audio.Play();
        StartCoroutine(FinishWait());
    }
    
    void WrongClick()
    {
        Debug.Log("Wrong Answer! Try Again.");
        wrong_audio.Play();
        //wrong_alert.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
        StartCoroutine(WrongWait());
        //wrong_alert.transform.SetParent(null, false);
    }

    void CorrectClick()
    {
        Debug.Log("Right Answer!");
        correct_audio.Play();
        //correct_alert.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
        StartCoroutine(CorrectWait());
        //correct_alert.transform.SetParent(null, false);
        correct_arrow.transform.SetParent(null, false);
        wrong_arrow.transform.SetParent(null, false);
        wrong_arrow1.transform.SetParent(null, false);
        wrong_arrow2.transform.SetParent(null, false);
        question_no = question_no + 1;
        //player.Play();
        instantiated = false;
    }

    IEnumerator CorrectWait()
    {
        //Debug.Log("Waiting");
        correct_alert.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
        yield return new WaitForSeconds(3);
        correct_alert.transform.SetParent(null, false);
        //Debug.Log("Waited");
        player.Play();
    }

    IEnumerator WrongWait()
    {
        //Debug.Log("Waiting");
        wrong_alert.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
        yield return new WaitForSeconds(3);
        wrong_alert.transform.SetParent(null, false);
        //Debug.Log("Waited");
    }

    IEnumerator FinishWait()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(sceneID);
    }

    public void VideoTwo()
    {
        if (player.time >= 2.0 && question_no == 0)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                which_way.Play();
                position_correct.x = 158; position_correct.y = 70; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 16;
                position_wrong.x = -207; position_wrong.y = 65; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 152;

                position_wrong1.x = -207; position_wrong.y = 65; position_wrong.z = 0;
                rotation_wrong1.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 152;
            
                setCorrectArrowPosition();
                setWrongArrowPosition();
             
                instantiated = true;
            }

        }

        if (player.time >= 12.0 && question_no == 1)
        {
            player.Pause();
            if (!instantiated)
            {
                //  DataCollection.intersection_start = Time.time;
                data.GetIntersectionStart();
                which_way.Play();
               
                position_correct = new Vector3(-262, 182, 0);
                rotation_correct = new Vector3(0, 0, 136);
                position_wrong = new Vector3(263, 214, 0);
                rotation_wrong = new Vector3(19, 348, 57);

                position_wrong1 = new Vector3(4, 210, 0);
                rotation_wrong1 = new Vector3(0, 0, 91);

              //  position_wrong1.x = 263; position_wrong1.y = 39; position_wrong1.z = 0;
              //  rotation_wrong1.x = 0; rotation_wrong1.y = 0; rotation_wrong1.z = 0;
              
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();
               

                instantiated = true;
            }

        }

        if (player.time >= 17.0 && question_no == 2)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                // DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-91, 104, 0);
                position_wrong = new Vector3(308, 81, 0);
                rotation_wrong = new Vector3 (0, 0, 28);
                rotation_correct = new Vector3(0, 0, 133);

                setCorrectArrowPosition();
                setWrongArrowPosition();
               
                instantiated = true;
            }

        }

        if (player.time >= 23.0 && question_no == 3)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();
               
                position_correct = new Vector3(-212, 193, 0);
                rotation_correct = new Vector3(42, -7, 83);
                position_wrong= new Vector3(51,140,0);
                rotation_wrong= new Vector3(0,0,53);
                

                setCorrectArrowPosition();
                setWrongArrowPosition();
                instantiated = true;
            }

        }

        if (player.time >= 27.0 && question_no == 4)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();


                position_correct = new Vector3(-175, 336, 0);
                rotation_correct = new Vector3(40, 5, 88);
                position_wrong = new Vector3(57, 247, 0);
                rotation_wrong = new Vector3(0, 0, 36);

                setCorrectArrowPosition();
                setWrongArrowPosition();

                instantiated = true;
            }

        }

        if (player.time >= 32.0 && question_no == 5)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //  DataCollection.intersection_start = Time.time;
                which_way.Play();


                position_wrong = new Vector3(-67, 284, 0);
                rotation_wrong = new Vector3(38, 1, 86);
                position_correct = new Vector3(-395, 215, 0);
                rotation_correct = new Vector3(49, 356, 168);

                setCorrectArrowPosition();
                setWrongArrowPosition();

                instantiated = true;
            }

        }

        if (player.time >= 39.0 && question_no == 6)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_wrong = new Vector3(-28, 249, 0);
                rotation_wrong = new Vector3(39, 329, 129);
                position_correct = new Vector3(392, 171, 0);
                rotation_correct = new Vector3(38, -1, 7);
                setCorrectArrowPosition();
                setWrongArrowPosition();

                instantiated = true;
            }

        }

        if (player.time >= 43.0 && question_no == 7)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();
         
                position_correct = new Vector3(-115, 202, 0);
                rotation_correct = new Vector3(31, 20, 87);
                position_wrong = new Vector3(-450, 129, 0);
                rotation_wrong = new Vector3(32, 351, 158);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                instantiated = true;
            }

        }

        if (player.time >= 51.0 && question_no == 8)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //  DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(247,236,0);
                rotation_correct = new Vector3(44,6,23);
                position_wrong = new Vector3(-395, 232, 0);
                rotation_wrong = new Vector3(37,-19,152);
                position_wrong1 = new Vector3(-51,278,0);
                rotation_wrong1 = new Vector3(0,0,91);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();
                instantiated = true;
            }

        }

        if (player.time >= 55.0 && question_no == 9)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-333, 266, 0);
                rotation_correct = new Vector3(40, 353, 168);
                position_wrong = new Vector3(644, 504, 0);
                rotation_wrong = new Vector3(37, 3, 91);
                position_wrong1 = new Vector3(815, 377, 0);
                rotation_wrong1 = new Vector3(31, 4, 18);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();

                instantiated = true;
            }

        }

        if (player.time >= 59.0 && question_no == 10)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-34, 388, 0);
                rotation_correct = new Vector3(34,-12,92);
                position_wrong = new Vector3(-391, 427, 0);
                rotation_wrong = new Vector3(36, 0, 119);
                position_wrong1 = new Vector3(-222, 420, 0);
                rotation_wrong1 = new Vector3(38, -1, 105);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();

                instantiated = true;
            }

        }

        if (player.time >= 63 && question_no == 11)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-198, 400, 0);
                rotation_correct = new Vector3(40, -7, 168);
                position_wrong = new Vector3(143,346,0);
                rotation_wrong = new Vector3(34,-21,40);
                position_wrong1 = new Vector3(-11,361,0);
                rotation_wrong1 = new Vector3(24, 0, 62);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();


                instantiated = true;
            }

        }

        if (player.time >= 65 && question_no == 12)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-499, 395, 0);
                rotation_correct = new Vector3(20,-7,168);
                position_wrong = new Vector3(255,244,0);
                rotation_wrong = new Vector3(34,-35,16);
                position_wrong1 = new Vector3(-290,428,0);
                rotation_wrong1 = new Vector3(0,0,119);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();

                instantiated = true;
            }

        }


        if (player.time >= 71 && question_no == 13)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-491,412,0);
                rotation_correct = new Vector3(40,-7,168);
                position_wrong = new Vector3(113,346,0);
                rotation_wrong = new Vector3(44,0,20);
              
                setCorrectArrowPosition();
                setWrongArrowPosition();
         
                instantiated = true;
            }

        }

        if (player.time >= 79 && question_no == 14)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(187,266,0);
                rotation_correct = new Vector3(26,0,0);
                position_wrong = new Vector3(-402,346,0);
                rotation_wrong = new Vector3(37,-1,163);
                position_wrong1 = new Vector3(-128,324,0);
                rotation_wrong1 = new Vector3(25,0,91);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();
                instantiated = true;
            }

        }


        if (player.time >= 84 && question_no == 15)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-65,359,0);
                rotation_correct = new Vector3(24,-4,108);
                position_wrong = new Vector3(165,412,0);
                rotation_wrong = new Vector3(11,-24,24);
                position_wrong1 = new Vector3(-242,300,0);
                rotation_wrong1 = new Vector3(13,-5,125);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();
                instantiated = true;
            }

        }


        if (player.time >= 91 && question_no == 16)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-197,371,0);
                rotation_correct = new Vector3(33, -8, 107);
                position_wrong = new Vector3(58,346,0);
                rotation_wrong = new Vector3(31,1,46);
                position_wrong1 = new Vector3(-450,372,0);
                rotation_wrong1 = new Vector3(44,-25,135);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();
                instantiated = true;
            }

        }

        //Four arrow
        if (player.time >= 99 && question_no == 17)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //   DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-627,284,0);
                rotation_correct = new Vector3(31,3,156);
                position_wrong = new Vector3(593,98,0);
                rotation_wrong = new Vector3(29,10,16);
                position_wrong1 = new Vector3(-478, 367, 0);
                rotation_wrong1 = new Vector3(20, 349, 101);
                setCorrectArrowPosition();
                setWrongArrowPosition();
                setSecondWrongArrowPosition();
                Vector3 ThirdArrowPos =  new Vector3(-302,341,0);
                Vector3 ThirdArrowRot = new Vector3(12,-4,65);
                setThirddWrongArrowPosition(ThirdArrowPos,ThirdArrowRot);
                instantiated = true;
            }

        }



        if (player.time >= 103 && question_no == 18)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //     DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-82,274,0);
                rotation_correct = new Vector3(38,0,70);
                position_wrong = new Vector3(-354,298,0);
                rotation_wrong = new Vector3(27,0,-203);
               
                setCorrectArrowPosition();
                setWrongArrowPosition();
               
                instantiated = true;
            }

        }


        if (player.time >= 110 && question_no == 19)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(7, 287, 0);
                rotation_correct = new Vector3(0,0,27);
                position_wrong = new Vector3(-280,276,0);
                rotation_wrong = new Vector3(7,0,158);

                setCorrectArrowPosition();
                setWrongArrowPosition();

                instantiated = true;
            }

        }


        if (player.time >= 114 && question_no == 20)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //     DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(-93,266,0);
                rotation_correct = new Vector3(34, 21, 92);
                position_wrong = new Vector3(-375,141,0);
                rotation_wrong = new Vector3(25, 0, -178);

                setCorrectArrowPosition();
                setWrongArrowPosition();

                instantiated = true;
            }

        }


        if (player.time >= 119 && question_no == 21)
        {
            player.Pause();
            if (!instantiated)
            {
                data.GetIntersectionStart();
                //    DataCollection.intersection_start = Time.time;
                which_way.Play();

                position_correct = new Vector3(212,368,0);
                rotation_correct = new Vector3(39,0,40);
                position_wrong = new Vector3(-24,346,0);
                rotation_wrong = new Vector3(27, 0, 87);

                setCorrectArrowPosition();
                setWrongArrowPosition();


                DataCollection.final_intersection = true;
                instantiated = true;
                
            }

        }


    }

    public void setCorrectArrowPosition()
    {
        correct_arrow.transform.position = position_correct;
        correct_arrow.transform.eulerAngles = rotation_correct;
        correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
    }

    public void setWrongArrowPosition()
    {
        wrong_arrow.transform.position = position_wrong;
        wrong_arrow.transform.eulerAngles = rotation_wrong;
        wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
    }

    public void setSecondWrongArrowPosition()
    {
        wrong_arrow1.transform.position = position_wrong1;
        wrong_arrow1.transform.eulerAngles = rotation_wrong1;
        wrong_arrow1.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
    }


    public void setThirddWrongArrowPosition(Vector3 position,Vector3 rotation)
    {
        wrong_arrow2.transform.position = new Vector3(position.x,position.y,position.z);
        wrong_arrow2.transform.eulerAngles = new Vector3(rotation.x, rotation.y, rotation.z);
        wrong_arrow2.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
    }




    public void VideoOne()
    {
        if (player.time == 6.0 && question_no == 0)
        {
            player.Pause();
            if (!instantiated)
            {
           //     DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = 158; position_correct.y = 70; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 16;
                position_wrong.x = -207; position_wrong.y = 65; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 152;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time == 18.0 && question_no == 1)
        {
            player.Pause();
            if (!instantiated)
            {
            //    DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = -262; position_correct.y = 26; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 181;
                position_wrong.x = 263; position_wrong.y = 39; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 0;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time == 27.0 && question_no == 2)
        {
            player.Pause();
            if (!instantiated)
            {
            //    DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = -91; position_correct.y = 104; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 170;
                position_wrong.x = 308; position_wrong.y = 81; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 5;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time >= 38.5 && question_no == 3)
        {
            player.Pause();
            if (!instantiated)
            {
         //       DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = -212; position_correct.y = 48; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 166;
                position_wrong.x = 82; position_wrong.y = 30; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 22;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time == 41 && question_no == 4)
        {
            player.Pause();
            if (!instantiated)
            {
            //    DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = 136; position_correct.y = -1; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 20;
                position_wrong.x = -175; position_wrong.y = 8; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 149;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time == 47.0 && question_no == 5)
        {
            player.Pause();
            if (!instantiated)
            {
            //    DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = 248; position_correct.y = 27; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 9;
                position_wrong.x = -303; position_wrong.y = 15; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 177;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time == 52.0 && question_no == 6)
        {
            player.Pause();
            if (!instantiated)
            {
              //  DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = 251; position_correct.y = 22; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 13;
                position_wrong.x = -332; position_wrong.y = -32; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 172;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time >= 53.5 && question_no == 7)
        {
            player.Pause();
            if (!instantiated)
            {
              //  DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = -115; position_correct.y = 88; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 159;
                position_wrong.x = 295; position_wrong.y = 95; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 11;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time >= 69.2 && question_no == 8)
        {
            player.Pause();
            if (!instantiated)
            {
             //   DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = 64; position_correct.y = 117; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 10;
                position_wrong.x = -457; position_wrong.y = 74; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 185;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                instantiated = true;
            }

        }

        if (player.time >= 75.5 && question_no == 9)
        {
            player.Pause();
            if (!instantiated)
            {
           //     DataCollection.intersection_start = Time.time;
                which_way.Play();
                position_correct.x = -285; position_correct.y = 133; position_correct.z = 0;
                rotation_correct.x = 0; rotation_correct.y = 0; rotation_correct.z = 179;
                position_wrong.x = 225; position_wrong.y = 104; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 0;

                //newCorrect = Instantiate(correct_arrow) as UnityEngine.UI.Button;
                correct_arrow.transform.position = position_correct;
                correct_arrow.transform.eulerAngles = rotation_correct;
                correct_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                //newWrong = Instantiate(wrong_arrow) as UnityEngine.UI.Button;
                wrong_arrow.transform.position = position_wrong;
                wrong_arrow.transform.eulerAngles = rotation_wrong;
                wrong_arrow.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                position_wrong.x = -51; position_wrong.y = 268; position_wrong.z = 0;
                rotation_wrong.x = 0; rotation_wrong.y = 0; rotation_wrong.z = 90;
                wrong_arrow1.transform.position = position_wrong;
                wrong_arrow1.transform.eulerAngles = rotation_wrong;
                wrong_arrow1.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                DataCollection.final_intersection = true;
                instantiated = true;
            }

        }
    }
}
