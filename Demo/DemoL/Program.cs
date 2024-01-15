//Exemple 2 : 
//Probleme 

using DemoL.Exemple2.Avant;

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
    }else if (item.StartsWith("@"))
    {
        publication = new PublicationTypeMention();
    }
    else
    { publication = new Publication();}

    publication.Creation(item);
}
