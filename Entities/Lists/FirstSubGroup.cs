namespace WebApp_Semus.Entities.Lists
{
    public class FirstSubGroup : Base
    {
        public int PharmacologicalGroupID { get; set; }

        public virtual PharmacologicalGroup PharmacologicalGroup { get; set; }
    }
}
