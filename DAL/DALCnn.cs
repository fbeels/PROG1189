public sealed class DALCnn
{
    public static string getConnectionString()
    {
        return "server=(local);database = FinalProj; integrated security=sspi;";
    }
    private DALCnn()
    {
    }
}