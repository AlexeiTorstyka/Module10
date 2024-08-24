using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _scoreCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 9)
        {
            _scoreCount = Convert.ToInt32(_scoreText.text);
            _scoreCount += 400;
            _scoreText.text = _scoreCount.ToString();
            Debug.Log("detected orange\n" + _scoreCount);
        }
        if(collision.gameObject.layer == 8)
        {
            _scoreCount = Convert.ToInt32(_scoreText.text);
            _scoreCount += 600;
            _scoreText.text = _scoreCount.ToString();
            Debug.Log("detected green\n" + _scoreCount);
        }
        if (collision.gameObject.layer == 7)
        {
            _scoreCount = Convert.ToInt32(_scoreText.text);
            _scoreCount += 800;
            _scoreText.text = _scoreCount.ToString();
            Debug.Log("detected red\n" + _scoreCount);
        }
        if (collision.gameObject.layer == 6)
        {
            _scoreCount = Convert.ToInt32(_scoreText.text);
            _scoreCount += 1000;
            _scoreText.text = _scoreCount.ToString();
            Debug.Log("detected blue\n " + _scoreCount);
        }
    }   
}
