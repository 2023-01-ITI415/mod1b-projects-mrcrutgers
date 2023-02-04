using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI
public class HighScore : MonoBehaviour
{
public class HighScore : MonoBehaviour { 
    static private Text _UI_TEXT; 
    static private int _SCORE = 1000; 
    
    private Text txtCom; 

    void Awake () {  
         _UI_TEXT = GetComponent < Text >(); 
        }
}






static public int SCORE { 
     get { return _SCORE; } 
     private set { 
         _SCORE = value; 
         if ( _UI_TEXT != null ) { 
             _UI_TEXT.text = "High Score: " + value.ToString( "#, 0" ); 
            } 
    } 
}


// If the PlayerPrefs HighScore already exists, read it 
if (PlayerPrefs.HasKey(" HighScore")) {
    SCORE = PlayerPrefs.GetInt(" HighScore"); 
    }  // Assign the high score to HighScore

PlayerPrefs.SetInt(" HighScore", SCORE); 


            
static public void TRY_SET_HIGH_SCORE( int scoreToTry ) { 
     if ( scoreToTry < = SCORE ) return; // If scoreToTry is too low, return > SCORE = scoreToTry;

     SCORE = scoreToTry;




[Tooltip( "Check this box to reset the HighScore in PlayerPrefs" )] 
public bool resetHighScoreNow = false;
 
void OnDrawGizmos() { 
    if ( resetHighScoreNow ) { 
     resetHighScoreNow = false; 
    PlayerPrefs.SetInt( "HighScore", 1000 ); 
    Debug.LogWarning( "PlayerPrefs HighScore reset to 1,000." ); 
    } 
}

Gibson Bond, Jeremy. Introduction to Game Design, Prototyping, and Development (p. 1138). Pearson Education. Kindle Edition. 


}














