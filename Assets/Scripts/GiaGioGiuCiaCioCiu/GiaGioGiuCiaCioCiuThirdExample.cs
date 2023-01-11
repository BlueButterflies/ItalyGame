using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GiaGioGiuCiaCioCiuThirdExample : MonoBehaviour
{
    #region Variable
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public InputField inputTxt;
    public Image image;
    public Sprite[] sprites;

    private string[] words = { "CILIEGIA", "PARMEGGIANO", "FAGIANO","GIAGUARO","SCARAFAGGIA","PIGIAMA","VALIGIA",//0-6
                               "PRIGIONE","GIOIELLI","SEGUGIO","GIOCATTOLI","OROLOGIO","GIOSTRA","FAGIOLI",//7-13
                               "GIURIA","GIULLARE","GIUDICE",//14-16
                               "CIABATTE","CIAMBELLA","FRECCIA","ROCCIA","CAMICIA","BRACCIALETTO",//17-22
                               "CIOCCOLATO","BRACCIO","CIOTOLA","RICCIO","CIONDOLO",//23-27
                               "CIUCCIO","CIUFFO","ASCIUGAMANO","DOLCIUMI"};//28-31
    private string word;

    private string input;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RandomImages();
    }

    #region Random Images and Assing word for images
    private void RandomImages()
    {
        image.sprite = sprites[Random.Range(0,sprites.Length)];

        if (image.sprite == sprites[0])
        {
            word = words[0];
        }
        else if (image.sprite == sprites[1])
        {
            word = words[1];
        }
        else if (image.sprite == sprites[2])
        {
            word = words[2];
        }
        else if (image.sprite == sprites[3])
        {
            word = words[3];
        }
        else if (image.sprite == sprites[4])
        {
            word = words[4];
        }
        else if (image.sprite == sprites[5])
        {
            word = words[5];
        }
        else if (image.sprite == sprites[6])
        {
            word = words[6];
        }
        else if (image.sprite == sprites[7])
        {
            word = words[7];
        }
        else if (image.sprite == sprites[8])
        {
            word = words[8];
        }
        else if (image.sprite == sprites[9])
        {
            word = words[9];
        }
        else if (image.sprite == sprites[10])
        {
            word = words[10];
        }
        else if (image.sprite == sprites[11])
        {
            word = words[11];
        }
        else if (image.sprite == sprites[12])
        {
            word = words[12];
        }
        else if (image.sprite == sprites[13])
        {
            word = words[13];
        }
        else if (image.sprite == sprites[14])
        {
            word = words[14];
        }
        else if (image.sprite == sprites[15])
        {
            word = words[15];
        }
        else if (image.sprite == sprites[16])
        {
            word = words[16];
        }
        else if (image.sprite == sprites[17])
        {
            word = words[17];
        }
        else if (image.sprite == sprites[18])
        {
            word = words[18];
        }
        else if (image.sprite == sprites[19])
        {
            word = words[19];
        }
        else if (image.sprite == sprites[20])
        {
            word = words[20];
        }
        else if (image.sprite == sprites[21])
        {
            word = words[21];
        }
        else if (image.sprite == sprites[22])
        {
            word = words[22];
        }
        else if (image.sprite == sprites[23])
        {
            word = words[23];
        }
        else if (image.sprite == sprites[24])
        {
            word = words[24];
        }
        else if (image.sprite == sprites[25])
        {
            word = words[25];
        }
        else if (image.sprite == sprites[26])
        {
            word = words[26];
        }
        else if (image.sprite == sprites[27])
        {
            word = words[27];
        }
        else if (image.sprite == sprites[28])
        {
            word = words[28];
        }
        else if (image.sprite == sprites[29])
        {
            word = words[29];
        }
        else if (image.sprite == sprites[30])
        {
            word = words[30];
        }
        else if (image.sprite == sprites[31])
        {
            word = words[31];
        }
    }
    #endregion

    #region Read inputs
    public void ReadInputGiaGioGiu(string s)
    {
        input = s;
    }

    #endregion

    public void CheckBtn()
    {
        if (input.Contains(word) || input.Contains(word.ToLower()))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImages();

            inputTxt.text = "";
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            inputTxt.text = "";
        }
    }

    #region Buttons Return and Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit(); 
    }
    #endregion
}
