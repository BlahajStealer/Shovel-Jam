using UnityEngine;
using TMPro;

public class Minigames : MonoBehaviour
{

    public GameObject MarketScreen;
    public bool InMarket;
    public int MarketPoints;
    public TextMeshProUGUI PointsDisp;
    public GameObject[] Pills;
    public bool Started;
    public int SocialLevel;
    public int GaggleLevel;
    public int InfluencerLevel;
    public int AdsLevel;
    public int PromoLevel;    
    public int CurrentSocialLevel = 0;
    public int CurrentGaggleLevel = 0;
    public int CurrentInfluencerLevel = 0;
    public int CurrentAdsLevel = 0;
    public int CurrentPromoLevel = 0;

    public float EmailTime;
    public int RandEmailInt;
    public GameObject Inbox;
    public GameObject NewIn;
    public GameObject Sent;
    public bool inEmail;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inEmail = false;
        MarketScreen.SetActive(false);
        Started = true;
        RandEmailInt = Random.Range(50, 80);

        Inbox.SetActive(false);
        NewIn.SetActive(false);
        Sent.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        EmailTime = Time.deltaTime;

        if (EmailTime >= RandEmailInt)
        {
            Debug.Log("Email Sent!");
        }

        if (InMarket)
        {
            PointsDisp.text = "Points Left:" + MarketPoints;
        } else
        {
            PointsDisp.text = "";
        }
        if (InMarket == true && Input.GetKeyDown(KeyCode.Escape))
        {
            MarketScreen.SetActive(false);
            InMarket = false;
        }        
        if (inEmail == true && Input.GetKeyDown(KeyCode.Escape))
        {
            inEmail = false;
            Inbox.SetActive(false);
            NewIn.SetActive(false);
            Sent.SetActive(false);
        }
    }

    public void Email()
    {
        if (!InMarket)
        {
            Debug.Log("Email");
            Inbox.SetActive(true);
            inEmail = true;
        }
    }

    public void InboxScreen()
    {
        Debug.Log("Pressed");

        Inbox.SetActive(true);
        NewIn.SetActive(false);
        Sent.SetActive(false);
    }
    public void NewScreen()
    {
        Debug.Log("Pressed");

        Inbox.SetActive(false);
        NewIn.SetActive(true);
        Sent.SetActive(false);
    }
    public void SentScreen()
    {
        Debug.Log("Pressed");
        Inbox.SetActive(false);
        NewIn.SetActive(false);
        Sent.SetActive(true);
    }



    public void VSCode()
    {
        Debug.Log("Coding");
    }
    public void Hire()
    {
        Debug.Log("Hire");
    }
    public void Socials()
    {
        if (!inEmail)
        {
            Debug.Log("Socials");
            MarketScreen.SetActive(true);
            InMarket = true;
            if (Started)
            {
                for (int i = 0; i <= (Pills.Length - 1); i++) { Pills[i].SetActive(false); Debug.Log("Destroyed"); }
                Started = false;
            }
        }
    }




    public void S1()
    {
        SocialLevel = 1;
        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;
            for (int i = 0; i <= 8; i++)
            {
                if (i == 0)
                {
                    Pills[i].SetActive(true);
                } else {
                    Pills[i].SetActive(false);

                }
            }
            CurrentSocialLevel = 1;
        }
    }    
    public void S2()
    {
        SocialLevel = 2;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;
            for (int i = 0; i <= 8; i++)
            {
                if (i <= 1)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }
            }
            CurrentSocialLevel = 2;

        }
    }    
    public void S3()
    {
        SocialLevel = 3;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;

                for (int i = 0; i <= 8; i++)
                {
                    if (i <= 2)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
                CurrentSocialLevel = 3;


        }
    }    
    public void S4()
    {
        SocialLevel = 4;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;

                for (int i = 0; i <= 8; i++)
                {
                    if (i <= 3)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
            
            CurrentSocialLevel=4;
        }
    }    
    public void S5()
    {
        SocialLevel = 5;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;

                for (int i = 0; i <= 8; i++)
                {
                    if (i <= 4)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
                CurrentSocialLevel = 5;
            
        }
    }    
    public void S6()
    {
        SocialLevel = 6;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;

                for (int i = 0; i <= 8; i++)
                {
                    if (i <= 5)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
                CurrentSocialLevel = 6;
            
        }
    }    
    public void S7()
    {
        SocialLevel = 7;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;

                for (int i = 0; i <= 8; i++)
                {
                    if (i <= 6)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
                CurrentSocialLevel = 7;

            
        }
    }    
    public void S8()
    {
        SocialLevel = 8;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;
            for (int i = 0; i <= 8; i++)
                {
                    if (i <= 7)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
                CurrentSocialLevel=8;
            
        }
    }    
    public void S9()
    {
        SocialLevel = 9;

        if (MarketPoints >= (SocialLevel - CurrentSocialLevel))
        {
            MarketPoints -= SocialLevel - CurrentSocialLevel;

                for (int i = 0; i <= 8; i++)
                {
                    if (i <= 8)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }
                }
                CurrentSocialLevel=9;
            
        }
    }    
    public void G1()
    {
        GaggleLevel = 1;

            if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
            {
                MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

                    for (int i = 9; i <= 16; i++)
                    {
                        if (i <= 9)
                        {
                            Pills[i].SetActive(true);
                        }
                        else
                        {
                            Pills[i].SetActive(false);

                        }
                    }
                    CurrentGaggleLevel = 1;

                
            }
        
    }    
    public void G2()
    {
        GaggleLevel = 2;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

                CurrentGaggleLevel = 2;
                if (MarketPoints > 0)
                {
                    for (int i = 9; i <= 16; i++)
                    {
                        if (i <= 10)
                        {
                            Pills[i].SetActive(true);
                        }
                        else
                        {
                            Pills[i].SetActive(false);

                        }
                    }
                }
            
        }
    }    
    public void G3()
    {
        GaggleLevel = 3;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

                CurrentGaggleLevel = 3;

                    for (int i = 9; i <= 16; i++)
                    {
                        if (i <= 11)
                        {
                            Pills[i].SetActive(true);
                        }
                        else
                        {
                            Pills[i].SetActive(false);

                        }
                    }
                
            
        }
    }
    public void G4()
    {
        GaggleLevel = 4;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

            CurrentGaggleLevel = 4;
            for (int i = 9; i <= 16; i++)
                {
                    if (i <= 12)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            
        }
    }
    public void G5()
    {
        GaggleLevel = 5;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

            CurrentGaggleLevel = 5;
                for (int i = 9; i <= 16; i++)
                {
                    if (i <= 13)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            
        }
    }
    public void G6()
    {
        GaggleLevel = 6;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

                CurrentGaggleLevel = 6;
                for (int i = 9; i <= 16; i++)
                {
                    if (i <= 14)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            
        }
    }    
    public void G7()
    {
        GaggleLevel = 7;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

                CurrentGaggleLevel = 7;
                for (int i = 9; i <= 16; i++)
                {
                    if (i <= 15)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            
        }
    }    
    public void G8()
    {
        GaggleLevel = 8;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

            
                CurrentGaggleLevel = 8;
                for (int i = 9; i <= 16; i++)
                {
                    if (i <= 16)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            
        }
    }    
    public void G9()
    {
        GaggleLevel = 9;
        if (MarketPoints >= (GaggleLevel - CurrentGaggleLevel))
        {
            MarketPoints -= (GaggleLevel - CurrentGaggleLevel);

                CurrentGaggleLevel = 9;
                for (int i = 9; i <= 17; i++)
                {
                    if (i <= 17)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            
        }
    }    
    public void I1()
    {
        InfluencerLevel = 1;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 1;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 18)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I2()
    {
        InfluencerLevel = 2;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 2;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 19)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I3()
    {
        InfluencerLevel = 3;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 3;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 20)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I4()
    {
        InfluencerLevel = 4;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 4;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 21)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I5()
    {
        InfluencerLevel = 5;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 5;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 22)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I6()
    {
        InfluencerLevel = 6;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 6;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 23)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I7()
    {
        InfluencerLevel = 7;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 7;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 24)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I8()
    {
        InfluencerLevel = 8;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 8;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 25)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void I9()
    {
        InfluencerLevel = 9;
        if (MarketPoints >= (InfluencerLevel - CurrentInfluencerLevel))
        {
            MarketPoints -= (InfluencerLevel - CurrentInfluencerLevel);
            {
                CurrentInfluencerLevel = 9;
                for (int i = 18; i <= 26; i++)
                {
                    if (i <= 26)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void A1()
    {
        AdsLevel = 1;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);
            {
                CurrentAdsLevel = 1;
                for (int i = 27; i <= 35; i++)
                {
                    if (i <= 27)
                    {
                        Pills[i].SetActive(true);
                    }
                    else
                    {
                        Pills[i].SetActive(false);

                    }

                }
            }
        }
    }    
    public void A2()
    {
        AdsLevel = 2;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 2;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 28)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A3()
    {
        AdsLevel = 3;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 3;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 29)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A4()
    {
        AdsLevel = 4;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 4;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 30)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A5()
    {
        AdsLevel = 5;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 5;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 31)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A6()
    {
        AdsLevel = 6;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 6;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 32)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A7()
    {
        AdsLevel = 7;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 7;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 33)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A8()
    {
        AdsLevel = 8;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);

            CurrentAdsLevel = 8;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 34)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void A9()
    {
        AdsLevel = 9;
        if (MarketPoints >= (AdsLevel - CurrentAdsLevel))
        {
            MarketPoints -= (AdsLevel - CurrentAdsLevel);
            CurrentAdsLevel = 9;

            for (int i = 27; i <= 35; i++)
            {
                if (i <= 35)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P1()
    {
        PromoLevel = 1;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 1;
            for (int i = 36; i <= 44; i++)
            {
                if (i <= 36)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P2()
    {
        PromoLevel = 2;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 2;
            for (int i = 36; i <= 44; i++)
            {
                if (i <= 37)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P3()
    {
        PromoLevel = 3;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 3;


            for (int i = 36; i <= 44; i++)
            {
                if (i <= 38)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P4()
    {PromoLevel = 4;    
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 4;

            for (int i = 36; i <= 44; i++)
            {
                if (i <= 39)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P5()
    {
        PromoLevel = 5;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 5;

            for (int i = 36; i <= 44; i++)
            {
                if (i <= 40)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P6()
    {
        PromoLevel = 6;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 6;

            for (int i = 36; i <= 44; i++)
            {
                if (i <= 41)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P7()
    {
        PromoLevel = 7;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 7;

            for (int i = 36; i <= 44; i++)
            {
                if (i <= 42)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P8()
    {
        PromoLevel = 8;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 8;

            for (int i = 36; i <= 44; i++)
            {
                if (i <= 43)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }    
    public void P9()
    {
        PromoLevel = 9;
        if (MarketPoints >= (PromoLevel - CurrentPromoLevel))
        {
            MarketPoints -= (PromoLevel - CurrentPromoLevel);
            CurrentPromoLevel = 9;

            for (int i = 36; i <= 44; i++)
            {
                if (i <= 44)
                {
                    Pills[i].SetActive(true);
                }
                else
                {
                    Pills[i].SetActive(false);

                }

            }
        }
    }
}
