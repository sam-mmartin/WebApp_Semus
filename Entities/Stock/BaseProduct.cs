namespace WebApp_Semus.Entities.Stock
{
    public class BaseProduct
    {
        // Foreign Key Medicament
        public int MedicamentID { get; set; }

        // Atributes
        public int Quantity { get; set; }

        // Navegation Property
        public virtual Medicament Medicament { get; set; }
    }
}
