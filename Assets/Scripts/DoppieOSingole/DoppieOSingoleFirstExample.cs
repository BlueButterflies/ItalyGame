using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoppieOSingoleFirstExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text wordTxt;
    public Text firstBtnTxt;
    public Text secondBtnTxt;

    private string word;
    private string[] words = { "BABBO","BABBUINO","ABACO", "OBESO", "ABBATTERE",//0-4
                               "FIOCCO", "SCIOCCO", "FACCIA", "BACIO", "COCCO",//5-9
                               "ANEDDOTO","DADI", "ADDIZIONE", "ADDOBBO", "RADDRIZZARE",//10-14
                               "ABBUFFARE", "BAFFO", "MAFIA", "SOFFIARE", "PIFFERO",//15-19
                               "FORMAGGIO", "MAGIA", "MAGGIO", "FAGIANO", "LEGGO",//20-24
                               "PALLONE", "CAPPELLO", "GALLO","GELATO", "COLLINA", //25-29
                               "MAMMA", "MAMMIFERO", "CAMMINARE", "CAMERA", "CAMMELLO",//30-34
                               "NONNA", "DIVANO", "PANNO", "CAPANNA", "DANNO",//35-39
                               "CAPIRE", "COPIA", "PAPPA", "ZUPPA", "BRADIPO",//40-44
                               "ARROSTO", "FERRO","MARE", "BIRRA", "PARROCO",//45-49
                               "SASSO", "RISOTTO", "NASO", "BASSO", "CASSONETTO",//50-54
                               "TETTO", "SPAGHETTI", "BRUSCHETTA", "LATTE", "FRUTTA"};//55-59

    private bool IsDouble;
    private bool IsSingle;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtWordBtns();
    }

    #region Random words and assing txt word and txt butons
    private void RandomWordsAndAssingTxtWordBtns()
    {
        word = words[Random.Range(0,words.Length)];

        if (word == words[0])
        {
            wordTxt.text = "BA__O";

            firstBtnTxt.text = "B";
            secondBtnTxt.text = "BB";

            IsDouble= true;
            IsSingle = false;
        }
        else if (word == words[1])
        {
            wordTxt.text = "BA__UINO";

            firstBtnTxt.text = "B";
            secondBtnTxt.text = "BB";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[2])
        {
            wordTxt.text = "A__ACO";

            firstBtnTxt.text = "B";
            secondBtnTxt.text = "BB";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[3])
        {
            wordTxt.text = "O__ESO";

            firstBtnTxt.text = "B";
            secondBtnTxt.text = "BB";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[4])
        {
            wordTxt.text = "A__ATTERE";

            firstBtnTxt.text = "B";
            secondBtnTxt.text = "BB";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[5])
        {
            wordTxt.text = "FIO__O";

            firstBtnTxt.text = "C";
            secondBtnTxt.text = "CC";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[6])
        {
            wordTxt.text = "SCIO__O";

            firstBtnTxt.text = "C";
            secondBtnTxt.text = "CC";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[7])
        {
            wordTxt.text = "FA__IA";

            firstBtnTxt.text = "C";
            secondBtnTxt.text = "CC";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[8])
        {
            wordTxt.text = "BA__IO";

            firstBtnTxt.text = "C";
            secondBtnTxt.text = "CC";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[9])
        {
            wordTxt.text = "CO__O";

            firstBtnTxt.text = "C";
            secondBtnTxt.text = "CC";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[10])
        {
            wordTxt.text = "ANE__OTO";

            firstBtnTxt.text = "D";
            secondBtnTxt.text = "DD";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[11])
        {
            wordTxt.text = "DA__I";

            firstBtnTxt.text = "D";
            secondBtnTxt.text = "D";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[12])
        {
            wordTxt.text = "A__IZIONE";

            firstBtnTxt.text = "D";
            secondBtnTxt.text = "DD";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[13])
        {
            wordTxt.text = "A__OBBO";

            firstBtnTxt.text = "D";
            secondBtnTxt.text = "DD";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[14])
        {
            wordTxt.text = "RA__RIZZARE";

            firstBtnTxt.text = "D";
            secondBtnTxt.text = "DD";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[15])
        {
            wordTxt.text = "ABBU__ARE";

            firstBtnTxt.text = "F";
            secondBtnTxt.text = "FF";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[16])
        {
            wordTxt.text = "BA__O";

            firstBtnTxt.text = "F";
            secondBtnTxt.text = "FF";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[17])
        {
            wordTxt.text = "MA__IA";

            firstBtnTxt.text = "F";
            secondBtnTxt.text = "FF";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[18])
        {
            wordTxt.text = "SO__IARE";

            firstBtnTxt.text = "F";
            secondBtnTxt.text = "FF";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[19])
        {
            wordTxt.text = "PI__ERO ";

            firstBtnTxt.text = "F";
            secondBtnTxt.text = "FF";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[20])
        {
            wordTxt.text = "FORMA__IO ";

            firstBtnTxt.text = "G";
            secondBtnTxt.text = "GG";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[21])
        {
            wordTxt.text = "MA__IA ";

            firstBtnTxt.text = "G";
            secondBtnTxt.text = "GG";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[22])
        {
            wordTxt.text = "MA__IO ";

            firstBtnTxt.text = "G";
            secondBtnTxt.text = "GG";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[23])
        {
            wordTxt.text = "FA__IANO ";

            firstBtnTxt.text = "G";
            secondBtnTxt.text = "GG";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[24])
        {
            wordTxt.text = "LE__O ";

            firstBtnTxt.text = "G";
            secondBtnTxt.text = "GG";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[25])
        {
            wordTxt.text = "PA__ONE ";

            firstBtnTxt.text = "L";
            secondBtnTxt.text = "LL";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[26])
        {
            wordTxt.text = "CAPPE__O ";

            firstBtnTxt.text = "L";
            secondBtnTxt.text = "LL";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[27])
        {
            wordTxt.text = "GA__O ";

            firstBtnTxt.text = "L";
            secondBtnTxt.text = "LL";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[28])
        {
            wordTxt.text = "GE__ATO ";

            firstBtnTxt.text = "L";
            secondBtnTxt.text = "LL";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[29])
        {
            wordTxt.text = "CO__INA ";

            firstBtnTxt.text = "L";
            secondBtnTxt.text = "LL";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[30])
        {
            wordTxt.text = "MA__A ";

            firstBtnTxt.text = "M";
            secondBtnTxt.text = "MM";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[31])
        {
            wordTxt.text = "MA__IFERO ";

            firstBtnTxt.text = "M";
            secondBtnTxt.text = "MM";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[32])
        {
            wordTxt.text = "CA__INARE ";

            firstBtnTxt.text = "M";
            secondBtnTxt.text = "MM";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[33])
        {
            wordTxt.text = "CA__ERA ";

            firstBtnTxt.text = "M";
            secondBtnTxt.text = "MM";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[34])
        {
            wordTxt.text = "CA__ELLO ";

            firstBtnTxt.text = "M";
            secondBtnTxt.text = "MM";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[35])
        {
            wordTxt.text = "NO__A ";

            firstBtnTxt.text = "N";
            secondBtnTxt.text = "NN";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[36])
        {
            wordTxt.text = "DIVA__O ";

            firstBtnTxt.text = "N";
            secondBtnTxt.text = "NN";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[37])
        {
            wordTxt.text = "PA__O ";

            firstBtnTxt.text = "N";
            secondBtnTxt.text = "NN";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[38])
        {
            wordTxt.text = "CAPA__A ";

            firstBtnTxt.text = "N";
            secondBtnTxt.text = "NN";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[39])
        {
            wordTxt.text = "DA__O ";

            firstBtnTxt.text = "N";
            secondBtnTxt.text = "NN";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[40])
        {
            wordTxt.text = "CA__IRE ";

            firstBtnTxt.text = "P";
            secondBtnTxt.text = "PP";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[41])
        {
            wordTxt.text = "CO__IA ";

            firstBtnTxt.text = "P";
            secondBtnTxt.text = "PP";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[42])
        {
            wordTxt.text = "PA__A ";

            firstBtnTxt.text = "P";
            secondBtnTxt.text = "PP";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[43])
        {
            wordTxt.text = "ZU__A ";

            firstBtnTxt.text = "P";
            secondBtnTxt.text = "PP";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[44])
        {
            wordTxt.text = "BRADI__O ";

            firstBtnTxt.text = "P";
            secondBtnTxt.text = "PP";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[45])
        {
            wordTxt.text = "A__OSTO ";

            firstBtnTxt.text = "R";
            secondBtnTxt.text = "RR";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[46])
        {
            wordTxt.text = "FE__O ";

            firstBtnTxt.text = "R";
            secondBtnTxt.text = "RR";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[47])
        {
            wordTxt.text = "MA__E ";

            firstBtnTxt.text = "R";
            secondBtnTxt.text = "RR";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[48])
        {
            wordTxt.text = "BI__A ";

            firstBtnTxt.text = "R";
            secondBtnTxt.text = "RR";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[49])
        {
            wordTxt.text = "PA__OCO ";

            firstBtnTxt.text = "R";
            secondBtnTxt.text = "RR";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[50])
        {
            wordTxt.text = "SA__O ";

            firstBtnTxt.text = "S";
            secondBtnTxt.text = "SS";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[51])
        {
            wordTxt.text = "RI__OTTO ";

            firstBtnTxt.text = "S";
            secondBtnTxt.text = "SS";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[52])
        {
            wordTxt.text = "NA__O";

            firstBtnTxt.text = "S";
            secondBtnTxt.text = "SS";

            IsDouble = false;
            IsSingle = true;
        }
        else if (word == words[53])
        {
            wordTxt.text = "BA__O ";

            firstBtnTxt.text = "S";
            secondBtnTxt.text = "SS";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[54])
        {
            wordTxt.text = "CA__ONETTO ";

            firstBtnTxt.text = "S";
            secondBtnTxt.text = "SS";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[55])
        {
            wordTxt.text = "TE__O ";

            firstBtnTxt.text = "T";
            secondBtnTxt.text = "TT";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[56])
        {
            wordTxt.text = "SPAGHE__I";

            firstBtnTxt.text = "T";
            secondBtnTxt.text = "TT";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[57])
        {
            wordTxt.text = "BRUSCHE__A";

            firstBtnTxt.text = "T";
            secondBtnTxt.text = "TT";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[58])
        {
            wordTxt.text = "LA__E";

            firstBtnTxt.text = "T";
            secondBtnTxt.text = "TT";

            IsDouble = true;
            IsSingle = false;
        }
        else if (word == words[59])
        {
            wordTxt.text = "FRU__A";

            firstBtnTxt.text = "T";
            secondBtnTxt.text = "TT";

            IsDouble = true;
            IsSingle = false;
        }
    }

    #endregion

    #region Check buttons answer correct
    public void CheckFirstBtn()
    {
        if (IsSingle)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingTxtWordBtns();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void CheckSecondBtn() 
    {
        if (IsDouble)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingTxtWordBtns();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
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
        SceneManager.LoadScene(24);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
