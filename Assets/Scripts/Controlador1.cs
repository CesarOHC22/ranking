/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador1 : MonoBehaviour
{
    public List<string> ranks;
    public float timerValue = 90;
    public Text txtOrbs, txtPoints, txtDamage, txtItems, txtRangoTotal, txtRangoTimer, txtRangoOrbs, txtRangoPoints, txtRangoDamage, txtRangoItems;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerValue > 0)
        {
            timerValue += Time.deltaTime;
        }
        else
        {
            timerValue = 0;

        }
        DisplayTime(timerValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = Mathf.FloorToInt(timeToDisplay / 60);
        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);

    }

    public void Ranks(float timer, float orbs, float points, float damage, float items)
    {
        ranks = new List<string>();
        ranks.Add("C");
        ranks.Add("B");
        ranks.Add("A");
        ranks.Add("S");

        orbs = Random.Range(1000, 9999);
        txtOrbs.text = "" + orbs;
        points = Random.Range(1000, 9999);
        txtOrbs.text = "" + points;
        damage = Random.Range(0, 6);
        txtOrbs.text = "" + damage;
        items = Random.Range(0, 6);
        txtOrbs.text = "" + items;

        //rango de orbes
        if (orbs >= 7000)
        {
            txtRangoOrbs.text = "S";
        }
        else if (orbs >= 6000 && orbs < 7000)
        {
            txtRangoOrbs.text = "A";
        }
        else if (orbs >= 5000 && orbs < 6000)
        {
            txtRangoOrbs.text = "B";
        }
        else if (orbs <= 4999)
        {
            txtRangoOrbs.text = "C";
        }

        //rango de puntos
        if (points >= 7000)
        {
            txtRangoPoints.text = "S";
        }
        else if (points >= 6000 && points < 7000)
        {
            txtRangoPoints.text = "A";
        }
        else if (points >= 5000 && points < 6000)
        {
            txtRangoPoints.text = "B";
        }
        else if (points <= 4999)
        {
            txtRangoPoints.text = "C";
        }

        //rango de total
        if (orbs >= 5000 && points >= 5000)
        {
            txtRangoTotal.text = "S";
        }
        else if (orbs >= 5000 && points <= 4999)
        {
            txtRangoTotal.text = "A";
        }
        else if (points >= 5000 && orbs <= 4999)
        {
            txtRangoTotal.text = "A";
        }
        else if (orbs <= 4999 && points <= 4999)
        {
            txtRangoTotal.text = "B";
        }

        //rango de damage
        if (damage >= 5000 && points >= 5000)
        {
            txtRangoDamage.text = "C";
        }
        else if (damage == 1)
        {
            txtRangoDamage.text = "B";
        }
        else if (damage == 2 || damage == 3)
        {
            txtRangoDamage.text = "A";
        }
        else if (damage == 4 || damage == 5)
        {
            txtRangoDamage.text = "S";
        }

        //rango de items
        if (items >= 5000 && points >= 5000)
        {
            txtRangoItems.text = "C";
        }
        else if (items == 1)
        {
            txtRangoItems.text = "B";
        }
        else if (items == 2 || items == 3)
        {
            txtRangoItems.text = "A";
        }
        else if (items == 4 || items == 5)
        {
            txtRangoItems.text = "S";
        }
    }
}
/*
