namespace WebApp_Semus.Entities.Lists
{
    public class ThirdSubGroup : Base
    {
        public int SecondSubGroupID { get; set; }

        public virtual SecondSubGroup SecondSubGroup { get; set; }
    }
}
