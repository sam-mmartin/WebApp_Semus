using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class TypeProduct
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public List<TypeProduct> ListTypeProduct()
        {
            return new List<TypeProduct>
            {
                new TypeProduct{ID=1, Description="Medicamento"},
                new TypeProduct{ID=2, Description="Suprimento"}
            };
        }
    }
}
