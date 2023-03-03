namespace InterviewCS.Classes;

abstract class Being 
{
    public bool isAlive { get; set; }

    // Abstract methods do not have an implementation.
    public abstract void ShowInfo();
}