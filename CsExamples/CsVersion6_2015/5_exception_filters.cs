namespace CsExamples.CsVersion6_2015;

public class Examples5 {
    
    public void Run() {
        try
        {
            //Try statements.  
        }
        catch (Exception ex) when (ex.Message.Contains("404"))
        {
            //Catch statements.
        }
        catch (Exception ex) when (ex.Message.Contains("500"))
        {
            //Catch statements.
        }
        catch (Exception ex)
        {
            //Catch statements.
        }
        finally
        {
            //Finally statements.
        }
    }
    
}