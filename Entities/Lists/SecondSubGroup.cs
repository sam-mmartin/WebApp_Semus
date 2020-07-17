namespace WebApp_Semus.Entities.Lists
{
    public class SecondSubGroup : Base
    {
        public int FirstSubGroupID { get; set; }

        public virtual FirstSubGroup FirstSubGroup { get; set; }
    }
}
