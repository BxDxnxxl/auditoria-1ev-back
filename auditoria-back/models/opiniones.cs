namespace models;

public class Opinion
{
    private static int contadorId = 1;
    public int Id { get; set; }
    public string Review { get; set; }
    public int PeliculaId {get; set;}
    public double Puntuacion{get; set;}
    public string Usuario{get; set;}
    public DateTime fecha_creacion{get; set;}

    public Opinion(string review, int peliculaId, double puntuacion, string usuario )
    {
        Id = contadorId++;
        Review = review;
        PeliculaId = peliculaId;
        Puntuacion = puntuacion;  
        Usuario = usuario; 
        fecha_creacion = DateTime.Now;
    }

}