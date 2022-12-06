using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoppieOSingoleSecondExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text firstBtnTxt;
    public Text secondBtnTxt;
    public Text thirdBtnTxt;

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
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtBtns();
    }

    #region Random words and assing txt word and txt butons
    private void RandomWordsAndAssingTxtBtns()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "BABO";
            thirdBtnTxt.text = "BABBA";
        }
        else if (word == words[1])
        {
            firstBtnTxt.text = "BABUINO";
            secondBtnTxt.text = "BABUINI";
            thirdBtnTxt.text = word;
        }
        else if (word == words[2])
        {
            firstBtnTxt.text = "ABACCO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "ABBACCO";
        }
        else if (word == words[3])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "OBESSO";
            thirdBtnTxt.text = "OBBESO";
        }
        else if (word == words[4])
        {
            firstBtnTxt.text = "ABBATERE";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "ABATTERE";
        }
        else if (word == words[5])
        {
            firstBtnTxt.text = "FIOCKO";
            secondBtnTxt.text = "FIOCO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[6])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "SCIOCO";
            thirdBtnTxt.text = "SCIOCCU";
        }
        else if (word == words[7])
        {
            firstBtnTxt.text = "FACIA";
            secondBtnTxt.text = "FACHIA";
            thirdBtnTxt.text = word;
        }
        else if (word == words[8])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "BACCIO";
            thirdBtnTxt.text = "BUCIO";
        }
        else if (word == words[9])
        {
            
            firstBtnTxt.text = "COCO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "COCCU";
        }
        else if (word == words[10])
        {
            firstBtnTxt.text = "ANEDOTTO";
            secondBtnTxt.text = "ANEDOTO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[11])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "DADDI";
            thirdBtnTxt.text = "DADE";
        }
        else if (word == words[12])
        {
            firstBtnTxt.text = "ADIZIONE";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "ADDIZZIONE";
        }
        else if (word == words[13])
        {
            firstBtnTxt.text = "ADDOBO";
            secondBtnTxt.text = "ADOBBO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[14])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "RADRIZZARE";
            thirdBtnTxt.text = "RADRIZARE";
        }
        else if (word == words[15])
        {
            firstBtnTxt.text = "ABBUFARE";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "ABUFFARE";
        }
        else if (word == words[16])
        {
            firstBtnTxt.text = "BAFO";
            secondBtnTxt.text = "BAFI";
            thirdBtnTxt.text = word;
        }
        else if (word == words[17])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "MAFIE";
            thirdBtnTxt.text = "MAFFIA";
        }
        else if (word == words[18])
        {
            firstBtnTxt.text = "SOFFIARRE";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "SOFIARE";
        }
        else if (word == words[19])
        {
            firstBtnTxt.text = "PIFERRO";
            secondBtnTxt.text = "PIFFERRO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[20])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "FORMAGGIO";
            thirdBtnTxt.text = "FORMAGGIO";
        }
        else if (word == words[21])
        {
            firstBtnTxt.text = "MAGHIA";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "MAGGIA";
        }
        else if (word == words[22])
        {
            firstBtnTxt.text = "MAGHIO";
            secondBtnTxt.text = "MAGIO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[23])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "FAGGIANO";
            thirdBtnTxt.text = "FAGHIANO";
        }
        else if (word == words[24])
        {
            firstBtnTxt.text = "LEGO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "LEGHO";
        }
        else if (word == words[25])
        {
            firstBtnTxt.text = "PALONE";
            secondBtnTxt.text = "PALLONNE";
            thirdBtnTxt.text = word;
        }
        else if (word == words[26])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "CAPELO";
            thirdBtnTxt.text = "CAPELLO";
        }
        else if (word == words[27])
        {
            firstBtnTxt.text = "GALO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "GAGLO";
        }
        else if (word == words[28])
        {
            firstBtnTxt.text = "GELLATO";
            secondBtnTxt.text = "GELATTO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[29])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "COLLINNA";
            thirdBtnTxt.text = "COLINA";
        }
        else if (word == words[30])
        {
            firstBtnTxt.text = "MAMA";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "MAME";
        }
        else if (word == words[31])
        {
            firstBtnTxt.text = "MAMMIFFERO";
            secondBtnTxt.text = "MAMIFERRO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[32])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "CAMINNARE";
            thirdBtnTxt.text = "CAMMINARRE";
        }
        else if (word == words[33])
        {
            firstBtnTxt.text = "CAMMERA";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "CAMERRA";
        }
        else if (word == words[34])
        {
            firstBtnTxt.text = "CAMELLO";
            secondBtnTxt.text = "CAMMELO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[35])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "NONNA";
            thirdBtnTxt.text = "NONNA";
        }
        else if (word == words[36])
        {
            firstBtnTxt.text = "DIVANO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "DIVANO";
        }
        else if (word == words[37])
        {
            firstBtnTxt.text = "PANNO";
            secondBtnTxt.text = "PANNO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[38])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "CAPANNA";
            thirdBtnTxt.text = "CAPANNA";
        }
        else if (word == words[39])
        {
            firstBtnTxt.text = "DANNO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "DANNO";
        }
        else if (word == words[40])
        {
            firstBtnTxt.text = "CAPPIRE";
            secondBtnTxt.text = "CAPIRRE";
            thirdBtnTxt.text = word;
        }
        else if (word == words[41])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "COPIA";
            thirdBtnTxt.text = "COPIE";
        }
        else if (word == words[42])
        {
            firstBtnTxt.text = "PAPA";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "pappà".ToUpper();
        }
        else if (word == words[43])
        {
            firstBtnTxt.text = "ZUPA";
            secondBtnTxt.text = "ZUPe";
            thirdBtnTxt.text = word;
        }
        else if (word == words[44])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "BRADIPpO";
            thirdBtnTxt.text = "BRAdDIPO";
        }
        else if (word == words[45])
        {
            firstBtnTxt.text = "AROSTO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "ARROSTU";
        }
        else if (word == words[46])
        {
            firstBtnTxt.text = "FERO";
            secondBtnTxt.text = "FERI";
            thirdBtnTxt.text = word;
        }
        else if (word == words[47])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "MARRE";
            thirdBtnTxt.text = "MARRI";
        }
        else if (word == words[48])
        {
            firstBtnTxt.text = "BERRA";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "BIRA";
        }
        else if (word == words[49])
        {
            firstBtnTxt.text = "PARACO";
            secondBtnTxt.text = "PARRACCO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[50])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "SASO";
            thirdBtnTxt.text = "SASCO";
        }
        else if (word == words[51])
        {
            firstBtnTxt.text = "RISSOTTO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "RISOTO";
        }
        else if (word == words[52])
        {
            firstBtnTxt.text = "NASSO";
            secondBtnTxt.text = "NISO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[53])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "BESSO";
            thirdBtnTxt.text = "BASO";
        }
        else if (word == words[54])
        {
            firstBtnTxt.text = "CASONETTO";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "CASONETO";
        }
        else if (word == words[55])
        {
            firstBtnTxt.text = "TETO";
            secondBtnTxt.text = "TOTTO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[56])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "SPAGHITTI";
            thirdBtnTxt.text = "SPAGHETI";
        }
        else if (word == words[57])
        {
            firstBtnTxt.text = "BRUSCHETA";
            secondBtnTxt.text = word;
            thirdBtnTxt.text = "BRUSCETTA";
        }
        else if (word == words[58])
        {
            firstBtnTxt.text = "LATE";
            secondBtnTxt.text = "LATTO";
            thirdBtnTxt.text = word;
        }
        else if (word == words[59])
        {
            firstBtnTxt.text = word;
            secondBtnTxt.text = "FROTTA";
            thirdBtnTxt.text = "FRUTA";
        }
    }
    #endregion

    #region 3 Answers buttons
    public void FirstAnswerButton()
    {
        if (firstBtnTxt.text.Contains(word))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingTxtBtns();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondAnswerButton()
    {
        if (secondBtnTxt.text.Contains(word))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingTxtBtns();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdAnswerButton()
    {
        if (thirdBtnTxt.text.Contains(word))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingTxtBtns();
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
        SceneManager.LoadScene(25);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
