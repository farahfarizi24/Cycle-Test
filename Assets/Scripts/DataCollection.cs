using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class DataCollection : MonoBehaviour
{
    //static variables
    public static float start_time;
    public static float end_time;
    public static float total_time;
    public static float landmark_start;
    public static float landmark_end;
    public static float landmark_total;
    private static int landmark_correct;
    private static int landmark_wrong;
    public float intersection_start;
    private  float intersection_end;
    private static float intersection_total;
    public static float routemapping_total;
    public static int intersection_accuracy = 0;
    private static string time_now;
    public static bool final_intersection = false;
 
    private TMP_InputField user_input;
    public static string path;
    private StreamWriter sw;
    public string RefAddress;
    public void Awake()

    {
        //FileStream file = File.Create(Application.persistentDataPath+"participant_name"+"cycletestdata.csv");
        //FileStream file = File.Create(Application.persistentDataPath+"participant_name"+"cycletestdata.csv");
        //file.Close();
        // path = Application.persistentDataPath + "participant_name" + "cycletestdata.csv";
      
        path = Application.persistentDataPath + "CycleTestData.csv";
       // if (!File.Exists(path))
      //  {
        //    File.Create(path);
        //}
        RefAddress = path;
    
     //   isEnglish = true;
        //sw = new StreamWriter(new FileStream(path,FileMode.Create),Encoding.UTF8);
        //sw.Close();

        
       
        Debug.Log(path);

    }

    public string GetAddress()
    {
        return RefAddress;
    }
   
    public void GetUserID()
    {

        user_input = GameObject.FindObjectOfType<TMP_InputField>();
    }

    public void UpdateUserID() 
    {

        if (!File.Exists(path))
        {
            
            sw = File.AppendText(path);
            sw.Write("ID,Date and Time,Landmark Correct Score,Landmark Incorrect Score," +
                "Correct MultipleBins,Correct Paketbox,Correct Sparkasse, Correct Plantations, Correct Bench,Correct BuildingBlocks,Correct RedCone,Correct ATV," + "Correct WoodShed," + "Correct RoadSign," +"Correct Betzentube,"+ "Correct Metzgerei," + "Correct Mailbox," + "Correct Bakery," + "Correct Shop," +" Correct Motorbike,"+ "Correct RedShop," + "Correct Monument," + "Correct Sculpture," + "Correct FireHydrant," +
               "Inc bin," + "Inc Door," + "Inc KindergartenSign," +"Inc Map,"+ "Inc Sign,"+ "Inc bench," +"Inc Bin2," + "Inc Streetmirror," + "Inc Rockstore," + "Inc PedestrianCross," + "Inc Statue" + "Inc Streetsign," +"Inc Store," + "Inc Tree," + "Inc Woodshed," +  "Inc Pole," + "Inc Bench," + " Inc Sign2," + "Inc Bins2," + "Inc Map,"+
                "Landmark Test Time," +
                "Time I1,Accuracy I1,Time I2,Accuracy I2,Time I3,Accuracy I3,Time I4,Accuracy I4,Time I5,Accuracy I5,Time I6,Accuracy I6,Time I7,Accuracy I7,Time I8,Accuracy I8,Time I9,Accuracy I9,Time I10,Accuracy I10," +
                      "Time I11,Accuracy I11,Time I12,Accuracy I12,Time I13,Accuracy I13,Time I14,Accuracy I14,Time I15,Accuracy I15,Time I16,Accuracy I16,Time I17,Accuracy I17,Time I18,Accuracy I18,Time I19,Accuracy I19,Time I20,Accuracy I20,"+
                      "Time I21,Accuracy I21,Time I22,Accuracy I22,"+
                "Total Reaction Time,Average Reaction Time, Total Test Time,");
            sw.Close();
           

        }

        //        "Correct Dog,Correct Ground,Correct Totem,Correct Garbage,Correct Slide,Correct Divider,Correct Bench,Correct Fountain,Correct Statue,Correct Hoops," +
        // "Incorrect Sign,Incorrect Ducks,Incorrect Vase,Incorrect Pipes,Incorrect Trash,Incorrect Cycle,Incorrect Bench,Incorrect Fountain,Incorrect Rock,Incorrect Toilet," +
        sw = File.AppendText(path);
        sw.Write("\n" + user_input.text);
        sw.Close();
    }

    public void GetStartTime()
    {
        time_now = DateTime.Now.ToString("G");
        start_time = Time.time;
        sw = File.AppendText(path);
        sw.Write("," + time_now);
        sw.Close();
    }
  
  
    public void TotalTime()
    {
        end_time = Time.time;
        total_time = end_time - start_time;
        sw = File.AppendText(path);
        sw.Write("," + total_time);
        sw.Close();
    }

    public void GetLandmarkStart()
    {
        landmark_start = Time.time;
    }

    public void GetLandmarkEnd()
    {
        landmark_end = Time.time;
        landmark_total = landmark_end - landmark_start;
        sw = File.AppendText(path);
        sw.Write("," + landmark_total);
        sw.Close();
    }

    public void LandmarkDataUpdate()
    {
        sw = File.AppendText(path);
        sw.Write("," + LandmarkInput.correct_score);
        sw.Write("," + LandmarkInput.incorrect_score);
        sw.Close(); 
    }

    public void GetIntersectionStart()
    {
        intersection_start = Time.time;
    }

    public void GetIntersectionEnd()
    {
        intersection_end = Time.time;
        intersection_total = intersection_end - intersection_start;
        sw = File.AppendText(path);
        routemapping_total += intersection_total;
        sw.Write("," + intersection_total); 
        sw.Write("," + intersection_accuracy); 
        sw.Close();
        intersection_accuracy = 0;
        if (final_intersection)
        {
            sw = File.AppendText(path);
            sw.Write("," + routemapping_total);//total reaction time
            sw.Write("," + routemapping_total / 22); //average reaction time
            end_time = Time.time;
            total_time = end_time - start_time;
            sw.Write("," + total_time);//total test time
            sw.Close();
        }
    }

    public void IntersectionAccuracy()
    {
        intersection_accuracy++;
    }






     private string getPathMainData()
     {
     #if     UNITY_EDITOR
                 return Application.dataPath + "/Data/" + "Saved_Inventory.csv";
             //"Participant " + "   " + DateTime.Now.ToString("dd-MM-yy   hh-mm-ss") + ".csv";
         #elif   UNITY_ANDROID
                 return Application.persistentDataPath+"Saved_Inventory.csv";
         #elif   UNITY_IPHONE
                 return Application.persistentDataPath+"/"+"Saved_Inventory.csv";
         #else
                 return Application.dataPath +"/"+"Saved_Inventory.csv";
         #endif
     }

     private string getPathMainDataAndroid()
     {  
         return Application.persistentDataPath+"Saved_Inventory.csv";
     }

     private string getPathSerial()
     {
         #if UNITY_EDITOR
                 return Application.dataPath + "/Data/" + "Saved_Inventory_read.csv";
                 //"Participant " + "   " + DateTime.Now.ToString("dd-MM-yy   hh-mm-ss") + ".csv";
         #elif UNITY_ANDROID
                         return Application.persistentDataPath+"Saved_Inventory.csv";
         #elif UNITY_IPHONE
                         return Application.persistentDataPath+"/"+"Saved_Inventory.csv";
         #else
                         return Application.dataPath +"/"+"Saved_Inventory.csv";
         #endif
     }
    
}
   