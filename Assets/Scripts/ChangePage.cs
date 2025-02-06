using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangePage : MonoBehaviour
{
    private int pageIndex = 0;
   // public Button circular_ground, white_dog, blue_slide, park_bench, eagle_statue, garbage_bin, metal_hoops, water_fountain, wood_totem, yellow_divider;
   // public Button incorrect_sign, incorrect_toilet, incorrect_bench, incorrect_pipes, incorrect_rock, incorrect_cycle, incorrect_ducks, incorrect_fountain, incorrect_vase, incorrect_trash;
    public Button next_button, back_button, finish_button;
    private Vector3 position1, position2, position3, position4;
    public List<Button> newCorrectLandmarks;
    public List<Button> newWrongLandmarks;
    public DataCollection dataScript;
    void Start()
    {
        MoveToPage();
        dataScript.GetLandmarkStart();
    }
    public void MoveToPage()
    {
        for (int i = 0; i < newCorrectLandmarks.Count; i++)
        {
            newCorrectLandmarks[i].transform.SetParent(null,false);
        }
        for(int i = 0; i < newWrongLandmarks.Count; i++)
        {
            newWrongLandmarks[i].transform.SetParent(null,false);
        }

        back_button.transform.SetParent(null, false);
        next_button.transform.SetParent(null, false);
        finish_button.transform.SetParent(null, false);
      /*  circular_ground.transform.SetParent(null, false);
        white_dog.transform.SetParent(null, false);
        blue_slide.transform.SetParent(null, false);
        park_bench.transform.SetParent(null, false);
        eagle_statue.transform.SetParent(null, false);
        garbage_bin.transform.SetParent(null, false);
        metal_hoops.transform.SetParent(null, false);
        water_fountain.transform.SetParent(null, false);
        wood_totem.transform.SetParent(null, false);
        yellow_divider.transform.SetParent(null, false);
        incorrect_sign.transform.SetParent(null, false);
        incorrect_bench.transform.SetParent(null, false);
        incorrect_cycle.transform.SetParent(null, false);
        incorrect_ducks.transform.SetParent(null, false);
        incorrect_fountain.transform.SetParent(null, false);
        incorrect_pipes.transform.SetParent(null, false);
        incorrect_rock.transform.SetParent(null, false);
        incorrect_toilet.transform.SetParent(null, false);
        incorrect_trash.transform.SetParent(null, false);
        incorrect_vase.transform.SetParent(null, false);*/
        position1.x = -730; position2.x = -260; position3.x = 231; position4.x = 729;

        switch (pageIndex)
        {

          /*  case 0:
                incorrect_sign.transform.position = position1;
                white_dog.transform.position = position2;
                incorrect_ducks.transform.position = position3;
                circular_ground.transform.position = position4;

                next_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                circular_ground.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                white_dog.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_sign.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_ducks.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                break;

            case 1:
                wood_totem.transform.position = position1;
                incorrect_vase.transform.position = position2;
                garbage_bin.transform.position = position3;
                incorrect_trash.transform.position = position4;
                next_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                back_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                wood_totem.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                garbage_bin.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_vase.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_trash.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                break;

            case 2:
                yellow_divider.transform.position = position1;
                blue_slide.transform.position = position2;
                incorrect_cycle.transform.position = position3;
                incorrect_pipes.transform.position = position4;
                next_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                back_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                yellow_divider.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                blue_slide.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_pipes.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_cycle.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                break;

            case 3:
                incorrect_bench.transform.position = position1;
                incorrect_fountain.transform.position = position2;
                water_fountain.transform.position = position3;
                park_bench.transform.position = position4;
                next_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                back_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                park_bench.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                water_fountain.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_bench.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_fountain.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                break;

            case 4:
                metal_hoops.transform.position = position1;
                incorrect_toilet.transform.position = position2;
                incorrect_rock.transform.position = position3;
                eagle_statue.transform.position = position4;
                back_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                next_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);

                metal_hoops.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                eagle_statue.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_toilet.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                incorrect_rock.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
                break;*/

            case 0:

                newCorrectLandmarks[0].transform.position = position1;
                newCorrectLandmarks[1].transform.position = position3;
                newWrongLandmarks[0].transform.position = position4;
                newWrongLandmarks[1].transform.position = position2;
                SetObjectParent(newCorrectLandmarks[0]);
                SetObjectParent(newCorrectLandmarks[1]);
                SetObjectParent(newWrongLandmarks[0]);
                SetObjectParent(newWrongLandmarks[1]);
                SetObjectParent(next_button);
                back_button.gameObject.transform.SetParent(null);
                //SetObjectParent(back_button);
                break;



            case 1:

                newCorrectLandmarks[2].transform.position = position4;
                newCorrectLandmarks[3].transform.position = position2;
                newWrongLandmarks[2].transform.position = position3;
                newWrongLandmarks[3].transform.position = position1;
                SetObjectParent(newCorrectLandmarks[2]);
                SetObjectParent(newCorrectLandmarks[3]);
                SetObjectParent(newWrongLandmarks[2]);
                SetObjectParent(newWrongLandmarks[3]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;

            case 2:

                newCorrectLandmarks[4].transform.position = position4;
                newCorrectLandmarks[5].transform.position = position1;
                newWrongLandmarks[4].transform.position = position3;
                newWrongLandmarks[5].transform.position = position2;
                SetObjectParent(newCorrectLandmarks[4]);
                SetObjectParent(newCorrectLandmarks[5]);
                SetObjectParent(newWrongLandmarks[4]);
                SetObjectParent(newWrongLandmarks[5]);
                SetObjectParent(back_button); SetObjectParent(next_button);


                break;

            case 3:
                newCorrectLandmarks[6].transform.position = position1;
                newCorrectLandmarks[7].transform.position = position4;
                newWrongLandmarks[6].transform.position = position2;
                newWrongLandmarks[7].transform.position = position3;
                SetObjectParent(newCorrectLandmarks[6]);
                SetObjectParent(newCorrectLandmarks[7]);
                SetObjectParent(newWrongLandmarks[6]);
                SetObjectParent(newWrongLandmarks[7]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;
            case 4:
                newCorrectLandmarks[8].transform.position = position3;
                newCorrectLandmarks[9].transform.position = position4;
                newWrongLandmarks[8].transform.position = position1;
                newWrongLandmarks[9].transform.position = position2;
                SetObjectParent(newCorrectLandmarks[8]);
                SetObjectParent(newCorrectLandmarks[9]);
                SetObjectParent(newWrongLandmarks[8]);
                SetObjectParent(newWrongLandmarks[9]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;

            case 5:
                newCorrectLandmarks[10].transform.position = position3;
                newCorrectLandmarks[11].transform.position = position1;
                newWrongLandmarks[10].transform.position = position2;
                newWrongLandmarks[11].transform.position = position4;
                SetObjectParent(newCorrectLandmarks[10]);
                SetObjectParent(newCorrectLandmarks[11]);
                SetObjectParent(newWrongLandmarks[10]);
                SetObjectParent(newWrongLandmarks[11]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;

            case 6:
                newCorrectLandmarks[12].transform.position = position2;
                newCorrectLandmarks[13].transform.position = position4;
                newWrongLandmarks[12].transform.position = position1;
                newWrongLandmarks[13].transform.position = position3;
                SetObjectParent(newCorrectLandmarks[12]);
                SetObjectParent(newCorrectLandmarks[13]);
                SetObjectParent(newWrongLandmarks[12]);
                SetObjectParent(newWrongLandmarks[13]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;

            case 7:
                newCorrectLandmarks[14].transform.position = position2;
                newCorrectLandmarks[15].transform.position = position1;
                newWrongLandmarks[14].transform.position = position3;
                newWrongLandmarks[15].transform.position = position4;
                SetObjectParent(newCorrectLandmarks[14]);
                SetObjectParent(newCorrectLandmarks[15]);
                SetObjectParent(newWrongLandmarks[14]);
                SetObjectParent(newWrongLandmarks[15]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;

            case 8:
                newCorrectLandmarks[16].transform.position = position1;
                newCorrectLandmarks[17].transform.position = position3;
                newWrongLandmarks[16].transform.position = position4;
                newWrongLandmarks[17].transform.position = position2;
                SetObjectParent(newCorrectLandmarks[16]);
                SetObjectParent(newCorrectLandmarks[17]);
                SetObjectParent(newWrongLandmarks[16]);
                SetObjectParent(newWrongLandmarks[17]);
                SetObjectParent(back_button);
                SetObjectParent(next_button);
                break;

            case 9:
                newCorrectLandmarks[18].transform.position = position2;
                newCorrectLandmarks[19].transform.position = position4;
                newWrongLandmarks[18].transform.position = position1;
                newWrongLandmarks[19].transform.position = position3;
                SetObjectParent(newCorrectLandmarks[18]);
                SetObjectParent(newCorrectLandmarks[19]);
                SetObjectParent(newWrongLandmarks[18]);
                SetObjectParent(newWrongLandmarks[19]);
                SetObjectParent(back_button);
                SetObjectParent(finish_button);

                break;

    
            default: break;

        }
    }

    public void SetObjectParent(Button buttonObject)
    {
        buttonObject.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
    }

    public void NextButton ()
    {
        pageIndex++;
        MoveToPage();
    }

    public void BackButton()
    {
        pageIndex--;
        MoveToPage();
    }

    
}
