using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// An enum defines a variable type with a few prenamed values // a
public enum eCardStateG
{
    drawpile,
    tableau,
    target,
    discard
}
public class CardGolf : Card
{ // Make sure CardGolf extends
    
    [Header("Set Dynamically: CardGolf")]
// This is how you use the enum eCardStateG
public eCardStateG state = eCardStateG.drawpile;
    // The hiddenBy list stores which other cards will keep this one face
   
public List<CardGolf> hiddenBy = new List<CardGolf>();
    // The layoutID matches this card to the tableau XML if it's a tableau
    
public int layoutID;
// The SlotDef class stores information pulled in from the LayoutXML

public SlotDef slotDef;

    override public void OnMouseUpAsButton()
    {
        // Call the CardClicked method on the Prospector singleton
        Prospector_G.S.CardClicked(this);
        // Also call the base class (Card.cs) version of this method
        base.OnMouseUpAsButton(); // a
    }

}