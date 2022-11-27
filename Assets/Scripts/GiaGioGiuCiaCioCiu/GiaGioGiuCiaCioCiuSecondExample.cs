using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GiaGioGiuCiaCioCiuSecondExample : MonoBehaviour
{
    #region Variable
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text wordTxt;
    public InputField inputAnswer;
    public Image image;
    public Sprite[] sprites;

    private string[] words = { "CILIEGIA", "PARMEGGIANO", "FAGIANO","GIAGUARO","SCARAFAGGIA","PIGIAMA","VALIGIA",//0-6
                               "PRIGIONE","GIOIELLI","SEGUGIO","GIOCATTOLI","OROLOGIO","GIOSTRA","FAGIOLI",//7-13
                               "GIURIA","GIULLARE","GIUDICE",//14-16
                               "CIABATTE","CIAMBELLA","FRECCIA","ROCCIA","CAMICIA","BRACCIALETTO",//17-22
                               "CIOCCOLATO","BRACCIO","CIOTOLA","RICCIO","CIONDOLO",//23-27
                               "CIUCCIO","CIUFFO","ASCIUGAMANO","DOLCIUMI"};//28-31
    private string word;

    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtImage();
    }

    #region Random words and assing wordTxt , image and buttons texts
    private void RandomWordsAndAssingTxtImage()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            wordTxt.text = "CI  GIA  LIE";
            image.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            wordTxt.text = "NO  MEG  PAR  GIA";
            image.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            wordTxt.text = "NO  FA  GIA";
            image.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            wordTxt.text = "GUA  GIA  RO";
            image.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            wordTxt.text = "RA  SCA  GIA  FAG";
            image.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            wordTxt.text = "GIA  PI  MA";
            image.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            wordTxt.text = "GIA  LI  VA";
            image.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            wordTxt.text = "NE  GIO  PRI";
            image.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            wordTxt.text = "LI  EL  GIOI";
            image.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            wordTxt.text = "SE  GIO  GU";
            image.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            wordTxt.text = "GIO  LI  CAT  TO";
            image.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            wordTxt.text = "O  GIO  LO  RO";
            image.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            wordTxt.text = "STRA  GIO";
            image.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            wordTxt.text = "LI  FA  GIO";
            image.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            wordTxt.text = "RIA  GIU";
            image.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            wordTxt.text = "LA  GIUL  RE";
            image.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            wordTxt.text = "CE  DI  GIU";
            image.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            wordTxt.text = "CIA  TE  BAT";
            image.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            wordTxt.text = "BEL  LA  CIAM";
            image.sprite = sprites[18];
        }
        else if (word == words[19])
        {
            wordTxt.text = "CIA  FREC";
            image.sprite = sprites[19];
        }
        else if (word == words[20])
        {
            wordTxt.text = "CIA  ROC";
            image.sprite = sprites[20];
        }
        else if (word == words[21])
        {
            wordTxt.text = "MI  CA  CIA";
            image.sprite = sprites[21];
        }
        else if (word == words[22])
        {
            wordTxt.text = "TO  LET  CIA  BRAC";
            image.sprite = sprites[22];
        }
        else if (word == words[23])
        {
            wordTxt.text = "CIOC  TO  CO  LA";
            image.sprite = sprites[23];
        }
        else if (word == words[24])
        {
            wordTxt.text = "CIO  BRAC";
            image.sprite = sprites[24];
        }
        else if (word == words[25])
        {
            wordTxt.text = "TO  CIO  LA";
            image.sprite = sprites[25];
        }
        else if (word == words[26])
        {
            wordTxt.text = "CIO  RIC";
            image.sprite = sprites[26];
        }
        else if (word == words[27])
        {
            wordTxt.text = "DO  LO  CION";
            image.sprite = sprites[27];
        }
        else if (word == words[28])
        {
            wordTxt.text = "CIO  CIUC";
            image.sprite = sprites[28];
        }
        else if (word == words[29])
        {
            wordTxt.text = "FO  CIUF";
            image.sprite = sprites[29];
        }
        else if (word == words[30])
        {
            wordTxt.text = "A  MA  NO  SCIU  GA";
            image.sprite = sprites[30];
        }
        else if (word == words[31])
        {
            wordTxt.text = "MI  CIU  DOL";
            image.sprite = sprites[31];
        }
    }
    #endregion

    #region  Check input
    public void CheckInput()
    {
        if (inputAnswer.text == word|| inputAnswer.text == word.ToLower())
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();

            inputAnswer.text = "";
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            inputAnswer.text = "";
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
        SceneManager.LoadScene(19);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
