namespace MadLibs.Models
{
  public class Libbles
  {
    private string _name;
    private string _adjective;
    private string _noun;

    public string GetName()
    {
      return _name;
    }

    public string GetAdjective()
    {
      return _adjective;

    }

    public string GetNoun()
    {
      return _noun;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public void SetAdjective(string newAdj)
    {
      _adjective = newAdj;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

  }
}
