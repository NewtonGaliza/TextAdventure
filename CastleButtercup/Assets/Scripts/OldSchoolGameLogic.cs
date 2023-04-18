using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OldSchoolGameLogic : MonoBehaviour
{
    [SerializeField] private TMP_Text storySegment;
    private string currentSegment;
    private int answer;

    // Start is called before the first frame update
    void Start()
    {
        OutsideCastleButtercup();
    }

    // Update is called once per frame
    void Update()
    {
        answer = 0;

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            answer = 1;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            answer = 2;
        }

        if(answer != 0)
        {
            if(currentSegment == "Outside Castle Buttercup" && answer == 1)
            {
                Moat();
            }
            else if(currentSegment == "Outside Castle Buttercup" && answer == 2)
            {
                Drawbridge();
            }
            else if(currentSegment == "Moat" && answer == 1)
            {
                OutsideCastleButtercup();
            }
            else if(currentSegment == "Drawbridge" && answer == 1)
            {
                CastleGrandEntrance();
            }
            else if(currentSegment == "Castle Grand Entrance" && answer == 1)
            {
                SideRoom();
            }
            else if(currentSegment == "Castle Grand Entrance" && answer == 2)
            {
                CastleTowerDoor();
            }
            else if(currentSegment == "Side Room" && answer == 1)
            {
                CastleGrandEntrance();
            }
            else if(currentSegment == "Castle Tower Door" && answer == 1)
            {
                BreakThroughCastleTowerDoor();
            }
            else if(currentSegment == "Castle Tower Door" && answer == 2)
            {
                CastleTower();
            }
            else if(currentSegment == "Break Through Castle Tower Door" && answer == 1)
            {
                CastleTowerDoor();
            }
            else if(currentSegment == "Castle Toower" && answer == 1)
            {
                OutsideCastleButtercup();
            }
            else if(currentSegment == "Castle Tower" && answer == 2)
            {
                ExitGame();
            }
        }
    }

    private void OutsideCastleButtercup()
    {
        storySegment.text = "Outside Castle Buttercup\n\nMedieval times\n\nYou, the great warrior, Bernard, stand before the Castle Buttercup.  You have come here to rescue Princess Luscious who is locked away in the castle tower.  " +
            "She was kidnapped by the evil King Buttercup – some grievance over being teased when he was a child in school.  Hey, his last name is BUTTERCUP.  You were not going to just let that slide!\n\nKing Buttercup and his guards " +
            "are no match against the strength and agility of a great warrior such as yourself.  Actually, you are quite near sighted and have no eye / hand coordination whatsoever.  But, you are not about to let that keep you from " +
            "saving your beloved, your honey bunch, your main squeeze, your love bunny…you get the idea.  She is REALLY curvy too!\n\nThe castle is surrounded by a moat.  A drawbridge stands before you leading across the moat to the " +
            "castle entrance.\n\nWhat do you, the great warrior, Bernard, do next?\n\nPress 1 to employ stealth and swim across the moat\n\nPress 2 to boldly charge across the drawbridge";
        currentSegment = " Outside Castle Buttercup";
    }

    private void Moat()
    {
        storySegment.text = "Moat\n\nAs you reach the bank of the moat, you look down to see the waters are infested with alligators.\n\nYikes! Looks like a strategic retreat is in order.\n\nDid they say “yikes!” in medieval times?  " +
            "Whatever.\n\nPress 1 to retreat";
        currentSegment = "Moat";
    }

    private void Drawbridge()
    {
        storySegment.text = "Drawbridge\n\nAs soon as you step onto the drawbridge, dozens of horrific creatures with menacing, grotesque claws, large, razor sharp teeth and wings to give them flight appear before you.  Normally, this would be a " +
            "show stopper.  However, you know these creatures are the creation of the wicked witch Gertrude who is in league with the evil King Buttercup.  You also know all of wicked witch Gertrude’s creatures melt away when exposed " +
            "to water.  And, there just happens to be five gallon buckets of water lining each side of the drawbridge at five foot intervals from one end of the drawbridge to the other.\n\nSeriously, what are the chances of that? It is " +
            "almost as if this were a convenient plot device in some fictional tale.  Nah!  That’s crazy talk!\n\nYou march across the drawbridge laying waste to the hideous creatures with buckets of water as you go.  You reach the end " +
            "of the drawbridge.\n\nPress 1 to enter the castle";
        currentSegment = "Drawbridge";
    }

    private void CastleGrandEntrance()
    {
        storySegment.text = "Castle Grand Entrance\n\nYou are in the grand entrance of Castle Buttercup.  To your right is a closed door.  In front of you, there is a long, winding staircase leading up to the castle tower.\n\nPress 1 to " +
            "enter the door on your right\n\nPress 2 to climb the staircase";
        currentSegment = "Castle Grand Entrance";
    }

    private void SideRoom()
    {
        storySegment.text = "Side Room\n\nYou enter the room to find 15 of King Buttercup’s servants wearing nothing but their skivvies engaged in a ferocious food fight.  Food is flying everywhere!\n\nUpon your entrance, the food fight " +
            "comes to a screeching halt and all of the servants turn to stare at you.\n\nThis is awkward.\n\nYou make your excuses and slowly back out of the room closing the door quietly behind you.  You can hear the sounds of the food " +
            "fight continuing on the other side of the closed door.\n\nWow!.......Just.......Wow!\n\nDid they say “wow!” in medieval times? Moving on.\n\nPress 1 to return to the grand entrance";
        currentSegment = "Side Room";
    }

    private void CastleTowerDoor()
    {
        storySegment.text = "Door to Castle Tower\n\nYou climb the staircase.  At top of the stairs, you face a large, very solid looking door.  The door is locked.  To the right of the door, a key hangs on a hook.\n\nPress 1 to break the " +
            "door down using your brute strength\n\nPress 2 to unlock the door using the key hanging on the hook";
        currentSegment = "Castle Tower Door";
    }

    private void BreakThroughCastleTowerDoor()
    {
        storySegment.text = "Break Through Castle Tower Door\n\nYour hurl yourself at the door many times attempting to break through.  Your left shoulder is now a mass of nasty looking black and blue bruises.\n\nThe door still stands before " +
            "you with no sign you have had any effect on it.\n\nThe key is looking like a very attractive option right now.\n\nPress 1 to reconsider your options";
        currentSegment = "Break Though Castle Tower Door";
    }

    private void CastleTower()
    {
        storySegment.text = "Castle Tower\n\nYou enter the castle tower to find the beautiful and really curvy Luscious standing before you.  Once the shock that you actually made it this far wears off, Luscious runs to you, throws her arms " +
            "around you and gives you a passionate kiss that goes on and on.\n\nYeah!  That’s the ticket!  Luscious and Bernard are together again in true bliss…..for now.\n\nWill King Buttercup have his revenge?\n\nWill wicked witch " +
            "Gertrude figure out how to create hideous creatures that don’t melt when exposed to water?\n\nWill Luscious one day realize she could do better?\n\nDon’t miss the next installment of the Castle Buttercup adventure!\n\nPress 1 to " +
            "play again\n\nPress 2 to exit";
        currentSegment = "Castle Tower";
    }

    private void ExitGame()
    {

    }


}
