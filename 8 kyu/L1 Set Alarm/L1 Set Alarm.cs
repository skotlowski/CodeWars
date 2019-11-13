public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
    // your code here
    if (employed == true && vacation == true)
    return false;
    else if (employed == false && vacation == true)
    return false;
    else if (employed == false && vacation == false)
    return false;
    else 
    return true;
    
  }
}