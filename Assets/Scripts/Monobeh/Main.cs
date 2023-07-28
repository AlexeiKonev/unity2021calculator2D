using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
  private  float sum = 0;
  public  Button btnSum;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

  public void ShowSum()
    {

    }
    public float Sum(float[] arr)
    {
        
        foreach (var item in arr)
        {
            sum += item;
            
        }
        return sum;
    }
}
