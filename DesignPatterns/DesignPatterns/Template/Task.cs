namespace DesignPatterns.Template;

public abstract class Task
{
    #region Fields

    private AuditTrail _trail;

    #endregion

    #region Constructor

    protected Task()
    {
        _trail = new AuditTrail();
    }
    
    protected Task(AuditTrail trail)
    {
        _trail = trail;
    }

    #endregion

    #region Execute

    public void Execute()
    {
        _trail.Record();
        
        DoExecute();
    }

    #endregion

    #region DoExecute

    protected abstract void DoExecute();

    #endregion
}