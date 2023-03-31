using net_ef_videogame;

using (VideogameContext db = new VideogameContext())
{
    //create
    Videogame videogameProva = new Videogame { Name = "Fifa23", Overview = "Bellissimo" };
    db.Videogames.Add(videogameProva);
    var ciao = db.SaveChanges();
    Console.WriteLine(ciao);
}