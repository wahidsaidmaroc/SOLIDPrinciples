

#region "Exemple 2"
 //:Probleme 

using DemoL.Exemple2.Avant;
using DemoL.Exemple4.Probleme;

List<string> ListCommentaire = new List<string>();
ListCommentaire.Add("Commentaire Said WAHID");
ListCommentaire.Add("#SaidWAHID");
ListCommentaire.Add("@SaidWAHID");


Publication publication;
foreach (var item in ListCommentaire)
{

    if (item.StartsWith("#"))
    {
        publication = new PublicationTypeTag();
        
    }
    else if (item.StartsWith("@"))
    {
        publication = new PublicationTypeMention();
    }
    else
    {
        publication = new Publication();
    }

    publication.Creation(item);
}

#endregion



#region "3"


using DemoL.Exemple3.Probleme;

Animal lion = new Lion();

lion.Speed();



#endregion




ObjetSaid oLine = new OLine();  
oLine.

Console.ReadKey();