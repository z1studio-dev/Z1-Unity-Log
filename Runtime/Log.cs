using UnityEngine;

public class Log : MonoBehaviour
{
    public static void LogMe(string source, string message){
        Debug.Log("Z1Log: " + source + " " + message);
    }

    public static void LogWarning(string source, string message){
        Debug.LogWarning("Z1Log: " + source + " " + message);
    }
    
    public static void LogError(string source, string message){
        Debug.LogError("Z1Log: " + source + " " + message);
    }

    public static void vectorLog(Pose vector){
        Debug.Log("Z1Log: " + vector.position.ToString());
    }

    public static void ClickLog(){
        Debug.Log("Z1Log: CLICKED");
    }

    public static void StateLog(string state){
        Debug.Log("Z1Log: " + state);
    }
}
