using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{

    public Text txtOrbs;
    public Text txtPoints;
    public Text txtDamage;
    public Text txtItems;
    public Text txtTotal;
    public Text txtTime;

 

    public int time;
    public int orbs;
    public int points;
    public int damage;
    public int items;
    public int seg;

    Rank ranking;
   
    // Start is called before the first frame update
    void Start()
    {
        ranking = new Rank(time, seg, orbs, points, damage, items);
    

        txtTotal.text = ranking.GetRank();
    
        txtTime.text = "00:" + ranking.time.ToString() + ":00";
        txtOrbs.text = ranking.orbs.ToString();
        txtDamage.text = ranking.damage.ToString();
        txtPoints.text = ranking.points.ToString();
        txtItems.text = ranking.items.ToString();
    }

}

public class Rank
{
    public string rankString;
    public string rankTime;
    public string rankDamage;
    public string rankPoints;
    public string rankOrbs;
    public string rankItems;
    public int time;
    public int timeSeg;
    public int orbs;
    public int points;
    public int damage;
    public int items;
    public int seg;
    public int total;

    public Rank(int time, int orbs, int points, int damage, int items, int seg)
    {
        this.time = time;
        this.orbs = orbs;
        this.points = points;
        this.damage = damage;
        this.items = items;
        timeSeg = seg;
    }

    public string GetRank()
    {
        total = (time + orbs + points);
        Debug.Log(total);
        total = (total - damage) - items;
        Debug.Log(total);

        if (total < 1600)
        {
            rankString = "C";
        }
        if (total >= 8000)
        {
            rankString = "S";
        }
        if (total >= 2000 && total < 8000)
        {
            rankString = "A";
        }
        if (total >= 1600 && total < 2000)
        {
            rankString = "B";
        }



        return rankString;
    }

    public string GetRankTime()
    {

        if (time > 0 && timeSeg < 60)
        {
            rankTime = "S";
        }
        if (time >= 2)
        {
            rankTime = "A";
        }
        if (time >= 4)
        {
            rankTime = "B";
        }
        if (time >= 6 && timeSeg < 60)
        {
            rankTime = "C";
        }

        return rankTime;
    }

     public int GetRankTimeSeg()
     {

            if (timeSeg >= 60)
            {
                timeSeg = 0;
            }


            return  timeSeg;
     }
        public string GetRankDamage()
        {

            if (damage == 0)
            {
                rankDamage = "S";
            }
            if (damage > 0)
            {
                rankDamage = "A";
            }
            if (damage > 30)
            {
                rankDamage = "B";
            }
            if (damage > 60)
            {
                rankDamage = "C";
            }



            return rankDamage;
        }
        public string GetRankPoints()
        {

            if (points > 6000)
            {
                rankPoints= "S";
            }
            if (points < 6000 && points > 4000)
            {
                rankPoints = "A";
            }
            if (points < 4000 && points >= 2000)
            {
                rankPoints = "B";
            }
            if (points < 2000 && points > 0)
            {
                rankPoints= "C";
            }



            return rankPoints;
        }
        public string GetRankOrbs()
        {

            if (orbs > 1800)
            {
                rankOrbs = "S";
            }
            if (items < 1800 && orbs >= 1200)
            {
                rankOrbs = "A";
            }
            if (items < 1200 && orbs >= 700)
            {
                rankOrbs= "B";
            }
            if (items < 700 && orbs >= 100)
            {
                rankOrbs = "C";
            }



            return rankOrbs;
        }
        public string GetRankItems()
        {

            if (items == 0)
            {
                rankItems = "S";
            }
            if (items > 0 && items < 4)
            {
                rankItems = "A";
            }
            if (items >= 4 && items < 10)
            {
                rankItems = "B";
            }
            if (items >= 10 && items < 15)
            {
                rankItems = "C";
            }



            return rankItems;
        }
}


