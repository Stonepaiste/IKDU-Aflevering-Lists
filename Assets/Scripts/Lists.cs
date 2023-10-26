using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
    
{

    // Start is called before the first frame update
    void Start()


    {
       FindPartyMember("Mathias Jaque", 1);
        // Vi putter vores parameter ind i metoden


    }
    public void FindPartyMember(string Myname, int MyNumber)
        // Her forventer vores FindPartyMember metode en string og en int som vi har definret i metoden ovenfor

                                    // Input parameter 1 should be you name
                                     // Input parameter 2 should be the place in the list
                                      // Where you want to be added
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Small joke",
            "Stonepaiste",
            "MattLeChock"
        };
    

        QuestPartyMembers.Insert(MyNumber, Myname );

        int listlength = QuestPartyMembers.Count;

        for (int i = 0; i <listlength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Mathias Jaqué")
            {
                Debug.Log("Glad you're here buddy!");
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
