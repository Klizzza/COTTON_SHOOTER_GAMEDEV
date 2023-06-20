using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageChange : MonoBehaviour
{

    public Sprite Bimborella; // I attched these from editor
    public Sprite Hormiga1;
    public Sprite Hormiga2;
    public Sprite Hormiga3;
    public Sprite Bagel1;
    public Sprite Bagel2;
    public Sprite Bagel3;
    public Sprite Bagel4;
    public Sprite Bagel5;
    public Sprite Bagel6;
    public Sprite Bagel7;
    public Sprite Bagel8;
    public Sprite Bagel9;
    public Sprite Bagel10;
    public Sprite Bagel11;
    public Sprite Bagel12;
    public Sprite Bagel13;
    public Sprite Bagel14;
    public Sprite Bagel15;



    public int imgNumberCount;


    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                GetComponent<Image>().sprite = Bimborella;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = Hormiga1;
                imgNumberCount++;
                break;
            case 2:
                GetComponent<Image>().sprite = Hormiga2;
                imgNumberCount++;
                break;
            case 3:
                GetComponent<Image>().sprite = Hormiga3;
                imgNumberCount++;
                break;
            case 4:
                GetComponent<Image>().sprite = Bagel1;
                imgNumberCount++;
                break;
            case 5:
                GetComponent<Image>().sprite = Bagel2;
                imgNumberCount++;
                break;
            case 6:
                GetComponent<Image>().sprite = Bagel3;
                imgNumberCount++;
                break;
            case 7:
                GetComponent<Image>().sprite = Bagel4;
                imgNumberCount++;
                break;
            case 8:
                GetComponent<Image>().sprite = Bagel5;
                imgNumberCount++;
                break;
            case 9:
                GetComponent<Image>().sprite = Bagel6;
                imgNumberCount++;
                break;
            case 10:
                GetComponent<Image>().sprite = Bagel7;
                imgNumberCount++;
                break;
            case 11:
                GetComponent<Image>().sprite = Bagel8;
                imgNumberCount++;
                break;
            case 12:
                GetComponent<Image>().sprite = Bagel9;
                imgNumberCount++;
                break;
            case 13:
                GetComponent<Image>().sprite = Bagel10;
                imgNumberCount++;
                break;
            case 14:
                GetComponent<Image>().sprite = Bagel11;
                imgNumberCount++;
                break;
            case 15:
                GetComponent<Image>().sprite = Bagel12;
                imgNumberCount++;
                break;
            case 16:
                GetComponent<Image>().sprite = Bagel13;
                imgNumberCount++;
                break;
            case 17:
                GetComponent<Image>().sprite = Bagel14;
                imgNumberCount++;
                break;
            case 18:
                GetComponent<Image>().sprite = Bagel15;
                imgNumberCount++;
                imgNumberCount = 0;
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}