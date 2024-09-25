using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoughQuestTwo : Rough
{
    [SerializeField] private Discharge _discharge;
    [SerializeField] private QuestTwo _quest;
    public Discharge Discharge => _discharge;
    public override void Interaction()
    {
        base.Interaction();
    }
    public override void Activate()
    {
        _quest.GetNumbers(_discharge);
    }
}
public enum Discharge { Units, Tens, Hundreds }
