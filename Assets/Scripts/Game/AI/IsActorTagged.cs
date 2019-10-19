using AI;

public class IsActorTagged : SelectWithOption
{
    TagCounter tagCounter;

    public override bool Check()
    {
        tagCounter = GetComponent<TagCounter>();

        tagCounter.Tags += 1;
        throw new System.NotImplementedException();
    }
}