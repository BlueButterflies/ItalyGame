using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlGliLiLliSecondExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text firstTxt;
    public Text secondTxt;
    public Text thirdTxt;
    public Text fourthTxt;

    public Image firstImg;
    public Image secondImg;
    public Image thirdImg;
    public Image fourthImg;

    public InputField inputField;

    private string[] words = {"SIGLA","INGLESE","GLADIATORE","GLOBO","GLASSA","GLORIA",//0-5
                              "SVEGLIA","MAGLIONE","CONIGLIO","PAGLIACCIO","MANIGLIA","AGLIO","CONCHIGLIA","BIGLIE","VENTAGLIO","FOGLIA","MEDAGLIA",//6-16
                              "MOBILIERE","ITALIA","CILIEGIA","SALIERA","OLIERA","CAVALIERE","BILIARDO","CANDELIERE","LIEVITO","OLIO",//17-26
                              "ALLIEVO","ALLIETARE","GIOIELLIERE","STALLIERE","SOLLIEVO"};//27-31

    private string word;
    private string input;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RandomWordsAndAssingImageTxt();

    }

    #region Read input answer, assing text for images red and check with button check
    public void ReadInput(string s)
    {
        input = s;
    }

    #region Random words and assing wordTxt
    private void RandomWordsAndAssingImageTxt()
    {
        thirdTxt.enabled = true;
        fourthTxt.enabled = true;

        thirdImg.enabled = true;
        fourthImg.enabled = true;

        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            firstTxt.text = "GLA";
            secondTxt.text = "SI";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[1])
        {
            firstTxt.text = "SE";
            secondTxt.text = "GLE";
            thirdTxt.text = "IN";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[2])
        {
            firstTxt.text = "RE";
            secondTxt.text = "DIA";
            thirdTxt.text = "TO";
            fourthTxt.text = "GLA";
        }
        else if (word == words[3])
        {
            firstTxt.text = "BO";
            secondTxt.text = "GLO";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[4])
        {
            firstTxt.text = "SA";
            secondTxt.text = "GLAS";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[5])
        {
            firstTxt.text = "RIA";
            secondTxt.text = "GLO";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[6])
        {
            firstTxt.text = "GLIA";
            secondTxt.text = "SVE";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[7])
        {
            firstTxt.text = "NE";
            secondTxt.text = "MA";
            thirdTxt.text = "GLIO";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[8])
        {
            firstTxt.text = "NI";
            secondTxt.text = "GLIO";
            thirdTxt.text = "CO";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[9])
        {
            firstTxt.text = "CIO";
            secondTxt.text = "PA";
            thirdTxt.text = "GLIAC";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[10])
        {
            firstTxt.text = "GLIA";
            secondTxt.text = "NI";
            thirdTxt.text = "MA";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[11])
        {
            firstTxt.text = "GLIO";
            secondTxt.text = "A";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[12])
        {
            firstTxt.text = "CHI";
            secondTxt.text = "CON";
            thirdTxt.text = "GLIA";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[13])
        {
            firstTxt.text = "GLIE";
            secondTxt.text = "BI";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[14])
        {
            firstTxt.text = "TA";
            secondTxt.text = "VEN";
            thirdTxt.text = "GLIO";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[15])
        {
            firstTxt.text = "GLIA";
            secondTxt.text = "FO";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[16])
        {
            firstTxt.text = "ME";
            secondTxt.text = "GLIA";
            thirdTxt.text = "DA";
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[17])
        {
            firstTxt.text = "BI";
            secondTxt.text = "LIE";
            thirdTxt.text = "RE";
            fourthTxt.text = "MO";
        }
        else if (word == words[18])
        {
            firstTxt.text = "LIA";
            secondTxt.text = "I";
            thirdTxt.text = "TA";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[19])
        {
            firstTxt.text = "CI";
            secondTxt.text = "GIA";
            thirdTxt.text = "LIE";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[20])
        {
            firstTxt.text = "LIE";
            secondTxt.text = "SA";
            thirdTxt.text = "RA";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[21])
        {
            firstTxt.text = "O";
            secondTxt.text = "RA";
            thirdTxt.text = "LIE";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[22])
        {
            firstTxt.text = "VA";
            secondTxt.text = "RE";
            thirdTxt.text = "CA";
            fourthTxt.text = "LIE";
        }
        else if (word == words[23])
        {
            firstTxt.text = "LIAR";
            secondTxt.text = "DO";
            thirdTxt.text = "BI";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[24])
        {
            firstTxt.text = "DE";
            secondTxt.text = "RE";
            thirdTxt.text = "CAN";
            fourthTxt.text = "LIE";
        }
        else if (word == words[25])
        {
            firstTxt.text = "VI";
            secondTxt.text = "LIE";
            thirdTxt.text = "TO";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[26])
        {
            firstTxt.text = "LIO";
            secondTxt.text = "O";
            thirdTxt.enabled = false;
            fourthTxt.enabled = false;

            thirdImg.enabled = false;
            fourthImg.enabled = false;
        }
        else if (word == words[27])
        {
            firstTxt.text = "VO";
            secondTxt.text = "LIE";
            thirdTxt.text = "AL";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[28])
        {
            firstTxt.text = "RE";
            secondTxt.text = "LIE";
            thirdTxt.text = "TA";
            fourthTxt.text = "AL";
        }
        else if (word == words[29])
        {
            firstTxt.text = "GIO";
            secondTxt.text = "RE";
            thirdTxt.text = "IEL";
            fourthTxt.text = "LIE";
        }
        else if (word == words[30])
        {
            firstTxt.text = "RE";
            secondTxt.text = "STAL";
            thirdTxt.text = "LIE";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
        else if (word == words[31])
        {
            firstTxt.text = "VO";
            secondTxt.text = "LIE";
            thirdTxt.text = "SOL";
            fourthTxt.enabled = false;

            fourthImg.enabled = false;
        }
    }
    #endregion

    public void CheckInputWithBtnCheck() 
    {
        if (input.Contains(word) || input.Contains(word.ToLower()))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingImageTxt();

            inputField.text = "";
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            inputField.text = "";
        }
    }
    #endregion

    #region Buttons Return, Next and Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(22);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
