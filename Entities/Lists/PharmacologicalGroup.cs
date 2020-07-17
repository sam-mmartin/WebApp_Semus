namespace WebApp_Semus.Entities.Lists
{
    public class PharmacologicalGroup : Base
    {
        public int SectionID { get; set; }

        public virtual Section Section { get; set; }
    }
}
