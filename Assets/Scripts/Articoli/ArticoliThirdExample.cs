using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArticoliThirdExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text wordTxt;

    //buttons text
    public Text unIlTxt;
    public Text unaLaTxt;
    public Text unLTxt;

    private string[] words = { "Iena", "Scimmia", "Cavallo", "Amica", "Automobile", "Astrice", "Piatto", "Orsa", "Fiore", "Torta", "Dolce", "Tavolo", "Sedia",
                               "Elfo", "Rosa", "Sasso", "Figlia", "Figlio", "Madre", "Padre", "Tartaruga", "Delfino", "Gnomo", "Maglione", "Orologio", "Cavaliere",
                               "Regina", "Re", "Principe", "Anatroccolo", "Albero", "Onda", "Isola", "Elefante", "Ventaglio", "Castello", "Torre", "Toro", "Quadro",
                               "Lavagna", "Ragno", "Pipistrello", "Campana", "Casa", "Stalla", "Maialino", "Canguro", "Miniera", "Farfalla", "Mosca", "Pinguino", "Letto" };
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RandomWords();
    }

    #region Random words and assing text with random word
    public void RandomWords()
    {
        word = words[Random.Range(0, words.Length)];//51

        if (word == words[0])
        {
            wordTxt.text = words[0];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[1])
        {
            wordTxt.text = words[1];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[2])
        {
            wordTxt.text = words[2];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[3])
        {
            wordTxt.text = words[3];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[4])
        {
            wordTxt.text = words[4];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[5])
        {
            wordTxt.text = words[5];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[6])
        {
            wordTxt.text = words[6];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[7])
        {
            wordTxt.text = words[7];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[8])
        {
            wordTxt.text = words[8];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[9])
        {
            wordTxt.text = words[9];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[10])
        {
            wordTxt.text = words[10];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[11])
        {
            wordTxt.text = words[11];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[12])
        {
            wordTxt.text = words[12];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[13])
        {
            wordTxt.text = words[13];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[14])
        {
            wordTxt.text = words[14];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[15])
        {
            wordTxt.text = words[15];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[16])
        {
            wordTxt.text = words[16];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[17])
        {
            wordTxt.text = words[17];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[18])
        {
            wordTxt.text = words[18];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[19])
        {
            wordTxt.text = words[19];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[20])
        {
            wordTxt.text = words[20];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[21])
        {
            wordTxt.text = words[21];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[22])
        {
            wordTxt.text = words[22];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[23])
        {
            wordTxt.text = words[23];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[24])
        {
            wordTxt.text = words[24];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[25])
        {
            wordTxt.text = words[25];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[26])
        {
            wordTxt.text = words[26];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[27])
        {
            wordTxt.text = words[27];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[28])
        {
            wordTxt.text = words[28];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[29])
        {
            wordTxt.text = words[29];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[30])
        {
            wordTxt.text = words[30];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[31])
        {
            wordTxt.text = words[31];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[32])
        {
            wordTxt.text = words[32];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[33])
        {
            wordTxt.text = words[33];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[34])
        {
            wordTxt.text = words[34];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[35])
        {
            wordTxt.text = words[35];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[36])
        {
            wordTxt.text = words[36];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[37])
        {
            wordTxt.text = words[37];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[38])
        {
            wordTxt.text = words[38];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[39])
        {
            wordTxt.text = words[39];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[40])
        {
            wordTxt.text = words[40];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[41])
        {
            wordTxt.text = words[41];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[42])
        {
            wordTxt.text = words[42];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[43])
        {
            wordTxt.text = words[43];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[44])
        {
            wordTxt.text = words[44];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[45])
        {
            wordTxt.text = words[45];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[46])
        {
            wordTxt.text = words[46];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[47])
        {
            wordTxt.text = words[47];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[48])
        {
            wordTxt.text = words[48];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[49])
        {
            wordTxt.text = words[49];
            unIlTxt.text = "UN";
            unaLaTxt.text = "UNA";
            unLTxt.text = "UN'";
        }
        else if (word == words[50])
        {
            wordTxt.text = words[50];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'";
        }
        else if (word == words[51])
        {
            wordTxt.text = words[51];
            unIlTxt.text = "IL";
            unaLaTxt.text = "LA";
            unLTxt.text = "L'"; 
        }
    }
    #endregion

    #region Buttons UN/IL, UNA/LA, UN'/L'
    public void BtnUnIl()
    {
        if (unIlTxt.text == "UN")
        {
            if (word == words[2] || word == words[6] || word == words[10] || word == words[17] || word == words[23] || word == words[28] ||
                word == words[29] || word == words[33] || word == words[34] || word == words[37] || word == words[40] || word == words[46])
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();
            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);

            }
        }
        else if (unIlTxt.text == "IL")
        {
            if (word == words[8] || word == words[11] || word == words[15] || word == words[19] || word == words[21] || word == words[22] ||
                word == words[25] || word == words[27] || word == words[35] || word == words[38] || word == words[41] || word == words[45] ||
                word == words[50] || word == words[51])
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();
            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);

            }
        }
    }

    public void BtnUnaLa()
    {
        if (unaLaTxt.text == "UNA")
        {
            if (word == words[0] || word == words[9] || word == words[12] || word == words[14] || word == words[20] || word == words[26] ||
                word == words[36] || word == words[43] || word == words[49])
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();
            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);

            }
        }
        else if (unaLaTxt.text == "LA")
        {
            if (word == words[1] || word == words[16] || word == words[18] || word == words[39] || word == words[42] || word == words[44] ||
                word == words[47] || word == words[48])
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();
            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);

            }
        }
    }

    public void BtnUNL()
    {
        if (unLTxt.text == "UN'")
        {
            if (word == words[4] || word == words[7] || word == words[31])
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();
            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);

            }
        }
        else if (unLTxt.text == "L'")
        {
            if (word == words[3] || word == words[5] || word == words[13] || word == words[24] || word == words[30] || word == words[32])
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();

            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);

            }
        }
    }
    #endregion

    #region Buttons Return, Exit
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
