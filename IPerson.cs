namespace OpenAndClosePrinciple
{
    //Implementing interface so that original person class does not need to be modified. I guess you could say it's "Open for expansion, 
    //closed for modification" hahaha
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}